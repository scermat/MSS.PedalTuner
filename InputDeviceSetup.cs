using MattScerri.Fanatec.V3.PedalCurve.Settings;
using Newtonsoft.Json;
using SharpDX.DirectInput;
using System.Data;

namespace MattScerri.Fanatec.V3.PedalCurve
{
    public partial class InputDeviceSetup : Form
    {
        private DirectInput directInput;
        private Joystick pedalsController;
        private Guid deviceGuid;
        private System.Timers.Timer timer;
        private string SignalProperty = string.Empty;
        private bool bMonitorSignal = false;

        public InputDeviceSetup()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            lblCalibrate.Text = string.Empty;

            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += PollPedalsController;

            directInput = new DirectInput();

            if (SettingsManager.HasSettings() && SettingsManager.settings.InputSettings.devices != null)
            {
                LoadComboBox(SettingsManager.settings.InputSettings.devices);
            }

            if (SettingsManager.HasSettings() && SettingsManager.settings.InputSettings.deviceGuid != null)
            {
                cbInputDevices.SelectedValue = SettingsManager.settings.InputSettings.deviceGuid;

                LoadControllerParams();
            }
        }

        private void PollPedalsController(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // Read input from the pedal set
            pedalsController.Poll();
            JoystickState state = pedalsController.GetCurrentState();

            if (bMonitorSignal)
            {
                tbBrakeSignal.Invoke(new Action(() =>
                {
                    //TODO: Add Support for Array (Sliders)
                    var rawValue = (int)state.GetType().GetProperty(SignalProperty).GetValue(state);

                    if (chkInvertSignal.Checked)
                    {
                        tbBrakeSignal.Value = (rawValue * -1) + int.Parse(SettingsManager.settings.InputSettings.brakeMaxVal);
                    }
                    else
                    {
                        tbBrakeSignal.Value = rawValue;
                    }
                }));
            }

            lblControllerProps.Invoke(new Action(() =>
            {
                lblControllerProps.Text = JsonConvert.SerializeObject(state, Formatting.Indented);
            }));
        }

        private void LoadControllerParams()
        {
            timer.Stop();

            if (cbInputDevices.Items.Count > 0)
            {
                deviceGuid = (Guid)cbInputDevices.SelectedValue;

                if (directInput.IsDeviceAttached(deviceGuid))
                {
                    // Initialize the joystick object
                    pedalsController = new Joystick(directInput, deviceGuid);
                    pedalsController.Properties.BufferSize = 128;
                    pedalsController.Acquire();

                    pedalsController.Poll();
                    var state = pedalsController.GetCurrentState();

                    List<string> controllerProps = new List<string>();
                    foreach (var property in state.GetType().GetProperties())
                    {
                        if (property.PropertyType.IsArray)
                        {
                            Array array = (Array)property.GetValue(state);
                            for (int i = 0; i < array.Length; i++)
                            {
                                controllerProps.Add(property.Name + "[" + i + "]");
                            }
                        }
                        else
                        {
                            controllerProps.Add(property.Name);
                        }
                    }

                    cbProperties.Items.AddRange(controllerProps.ToArray());

                    if (!string.IsNullOrEmpty(SettingsManager.settings.InputSettings.brakeProperty))
                    {
                        cbProperties.SelectedItem = SettingsManager.settings.InputSettings.brakeProperty;
                    }

                    if (!string.IsNullOrEmpty(SettingsManager.settings.InputSettings.brakeMinVal))
                    {
                        tbMinValue.Text = SettingsManager.settings.InputSettings.brakeMinVal;
                    }

                    if (!string.IsNullOrEmpty(SettingsManager.settings.InputSettings.brakeMaxVal))
                    {
                        tbMaxValue.Text = SettingsManager.settings.InputSettings.brakeMaxVal;
                    }

                    chkInvertSignal.Checked = SettingsManager.settings.InputSettings.brakeInvertSignal;

                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Selected device has been disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please load devices first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadInputDevices_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, Guid>> devices = new List<KeyValuePair<string, Guid>>();

            if (chkScanForWheelsOnly.Checked)
            {
                devices = directInput.GetDevices(DeviceType.Driving, DeviceEnumerationFlags.AttachedOnly).Select(x => new KeyValuePair<string, Guid>($"{x.ProductName} ({x.InstanceGuid})", x.InstanceGuid)).ToList();
            }
            else
            {
                devices = directInput.GetDevices(DeviceClass.All, DeviceEnumerationFlags.AttachedOnly).Select(x => new KeyValuePair<string, Guid>($"{x.ProductName} ({x.InstanceGuid})", x.InstanceGuid)).ToList();
            }
            SettingsManager.settings.InputSettings.devices = devices;
            SettingsManager.saveSettings();

            LoadComboBox(devices);
        }

        private void LoadComboBox(List<KeyValuePair<string, Guid>> devices)
        {
            cbInputDevices.DataSource = devices.ToArray();
            cbInputDevices.DisplayMember = "Key";
            cbInputDevices.ValueMember = "Value";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

        private void btnSaveGameInputProfile_Click(object sender, EventArgs e)
        {
            timer.Stop();

            SaveSettings();

            this.Close();
        }

        private void InputDeviceSetup_Load(object sender, EventArgs e)
        {

        }

        private void InputDeviceSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void SaveSettings()
        {
            SettingsManager.settings.InputSettings.deviceGuid = (Guid)cbInputDevices.SelectedValue;
            SettingsManager.settings.InputSettings.brakeProperty = cbProperties.SelectedItem.ToString();
            SettingsManager.settings.InputSettings.brakeMinVal = tbMinValue.Text;
            SettingsManager.settings.InputSettings.brakeMaxVal = tbMaxValue.Text;
            SettingsManager.settings.InputSettings.brakeInvertSignal = chkInvertSignal.Checked;

            SettingsManager.saveSettings();
        }

        private void btnApplySignal_Click(object sender, EventArgs e)
        {
            var testCheckOk = true;

            if (int.TryParse(tbMinValue.Text, out _))
            {
                SettingsManager.settings.InputSettings.brakeMinVal = tbMinValue.Text;
            }

            if (int.TryParse(tbMaxValue.Text, out _))
            {
                SettingsManager.settings.InputSettings.brakeMaxVal = tbMaxValue.Text;
            }

            if (string.IsNullOrWhiteSpace(SignalProperty))
            {
                testCheckOk = false;
                MessageBox.Show("Please select which controller property to  monitor for input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (int.TryParse(tbMinValue.Text, out int minBrakeVal))
            {
                tbBrakeSignal.Minimum = minBrakeVal;
            }
            else
            {
                testCheckOk = false;
                MessageBox.Show("Cannot read Minimum value. Must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (int.TryParse(tbMaxValue.Text, out int maxBrakeVal))
            {
                tbBrakeSignal.Maximum = maxBrakeVal;
            }
            else
            {
                testCheckOk = false;
                MessageBox.Show("Cannot read Maximum value. Must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (testCheckOk)
            {
                bMonitorSignal = true;
            }
            else
            {
                bMonitorSignal = false;
            }
        }

        private void cbInputDevices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadControllerParams();
        }

        private void cbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            SignalProperty = cbProperties.Text;
        }

        int calibrationStep = 0;
        JoystickState joyOffState;
        JoystickState joyOnState;

        private void btnCalibrate_Click(object sender, EventArgs e)
        {
            switch (calibrationStep % 4)
            {
                case 0:
                    StartCalibration();
                    break;
                case 1:
                    CalibrateOffPedal();
                    break;
                case 2:
                    CalibratePressedPedal();
                    break;
                case 3:
                    FinishCalibration();
                    break;
                default:
                    throw new InvalidOperationException("Calibration boo boo!");
            }
        }

        private void StartCalibration()
        {
            if (cbInputDevices.Items.Count > 0)
            {
                LoadControllerParams();
                btnCalibrate.Text = "Next";
                lblCalibrate.Text = "Click 'Next' with Pedal Fully Released.";

                calibrationStep++;
            }
        }

        private void CalibrateOffPedal()
        {
            pedalsController.Poll();
            joyOffState = pedalsController.GetCurrentState();
            lblCalibrate.Text = "Click 'Next' with Pedal Fully Pressed.";

            calibrationStep++;
        }

        private void CalibratePressedPedal()
        {
            pedalsController.Poll();
            joyOnState = pedalsController.GetCurrentState();
            btnCalibrate.Text = "Finish";
            lblCalibrate.Text = "Ready";

            calibrationStep++;
        }

        private void FinishCalibration()
        {
            var compareResult = compareJoyStates();
            if (compareResult != null)
            {
                cbProperties.Text = compareResult.prop;

                if (compareResult.offValue > compareResult.onValue)
                {
                    tbMinValue.Text = compareResult.onValue.ToString();
                    tbMaxValue.Text = compareResult.offValue.ToString();
                    chkInvertSignal.Checked = true;
                }
                else
                {
                    tbMinValue.Text = compareResult.offValue.ToString();
                    tbMaxValue.Text = compareResult.onValue.ToString();
                }

                SaveSettings();
            }
            else
            {
                btnCalibrate.Text = "Unable to calibrate. Please try again or try manual calibration.";
            }

            btnCalibrate.Text = "Calibrate";
            lblCalibrate.Text = string.Empty;

            calibrationStep++;
        }

        private JoyCompareState? compareJoyStates()
        {
            string propName = string.Empty;

            foreach (var field in joyOffState.GetType().GetProperties())
            {
                propName = field.Name;
                if (field.PropertyType == typeof(int))
                {
                    var offValue = (int)field.GetValue(joyOffState);
                    var onValue = (int)field.GetValue(joyOnState);

                    if (offValue != onValue && Math.Abs(offValue - onValue) > 10)
                    {
                        //Math.Abs(offValue-onValue) > 10 to eliminate over sensitive inputs
                        return new JoyCompareState(propName, offValue, onValue);
                    }
                }
            }

            return null;
        }
    }

    public class JoyCompareState
    {
        public string prop { get; set; }
        public int offValue { get; set; }
        public int onValue { get; set; }

        public JoyCompareState(string prop, int offValue, int onValue)
        {
            this.prop = prop;
            this.offValue = offValue;
            this.onValue = onValue;
        }
    }
}
