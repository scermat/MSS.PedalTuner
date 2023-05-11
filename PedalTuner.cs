using MattScerri.Fanatec.V3.PedalCurve.CurveFilter;
using MattScerri.Fanatec.V3.PedalCurve.Pedal;
using MattScerri.Fanatec.V3.PedalCurve.Settings;
using System.Windows.Forms.DataVisualization.Charting;

namespace MattScerri.Fanatec.V3.PedalCurve
{
    public partial class PedalTuner : Form
    {
        private PedalInput pedalInput;
        private PedalOutput pedalOutput;
        private PedalMonitor monitor;

        private CurveFilterType curveFilterType;
        private double factor = 1.0;
        private int monitorInterval = 25;

        private bool isMonitoring = false;

        private Series outputChartSeries;
        private Series inputChartSeries;

        public PedalTuner()
        {
            InitializeComponent();

            Init();
        }

        private void RefreshChart()
        {
            if (pedalInput != null)
            {
                chartPedalCurve.Series.Clear();

                // Configure series
                outputChartSeries = new Series("Output");
                outputChartSeries.ChartType = SeriesChartType.Line;
                outputChartSeries.Color = Color.Blue;
                outputChartSeries.BorderWidth = 1;
                chartPedalCurve.Series.Add(outputChartSeries);

                inputChartSeries = new Series("Input");
                inputChartSeries.ChartType = SeriesChartType.Line;
                inputChartSeries.Color = Color.Red;
                inputChartSeries.BorderWidth = 1;
                chartPedalCurve.Series.Add(inputChartSeries);

                // Set axis labels
                chartPedalCurve.ChartAreas[0].AxisX.Title = "Input Value";
                chartPedalCurve.ChartAreas[0].AxisY.Title = "Output Value";

                // Limit the height of the chart
                chartPedalCurve.ChartAreas[0].AxisY.Minimum = pedalInput.GetInputRange().MinValue;
                chartPedalCurve.ChartAreas[0].AxisY.Maximum = pedalInput.GetInputRange().MaxValue;
                chartPedalCurve.ChartAreas[0].AxisX.Minimum = pedalInput.GetInputRange().MinValue;
                chartPedalCurve.ChartAreas[0].AxisX.Maximum = pedalInput.GetInputRange().MaxValue;

                // Create input (linear) curve data
                int maxPedalInputValue = pedalInput.GetInputRange().MaxValue; // Set this to your fromRange.MaxValue
                for (int i = 0; i <= maxPedalInputValue; i++)
                {
                    double x = i;
                    double y = i;
                    inputChartSeries.Points.AddXY(x, y);
                }

                outputChartSeries.Points.Clear();

                // Create curve data
                int maxValue = pedalInput.GetInputRange().MaxValue; // Set this to your fromRange.MaxValue
                for (int i = 0; i <= maxValue; i++)
                {
                    double x = i;
                    double y = monitor.SampleSignal(i, factor);
                    outputChartSeries.Points.AddXY(x, y);
                }
            }
        }

        private void Init()
        {
            if (SettingsManager.HasInputDeviceConfigured())
            {
                InitPedals();
            }

            var filters = Enum.GetNames(typeof(CurveFilterType));
            cbFilterType.Items.Clear();
            cbFilterType.Items.AddRange(filters);

            cbFilterType.SelectedIndex = 0;

            InitInterval();
            InitFactor();
            InitCurveFilterType();

            SetProfile(Enum.Parse<CurveFilterType>(cbFilterType.Text));
        }

        private void InitPedals()
        {
            var deviceGuid = SettingsManager.settings.InputSettings.deviceGuid;

            int.TryParse(SettingsManager.settings.InputSettings.brakeMinVal, out int brakeMinVal);
            int.TryParse(SettingsManager.settings.InputSettings.brakeMaxVal, out int brakeMaxVal);

            var invertSignal = SettingsManager.settings.InputSettings.brakeInvertSignal;
            var joystickProperty = SettingsManager.settings.InputSettings.brakeProperty;

            tsLabelInputDevice.Text = $"Connected To: {SettingsManager.settings.InputSettings.deviceGuid}";

            pedalInput = new PedalInput(deviceGuid.Value, joystickProperty, brakeMinVal, brakeMaxVal, invertSignal);
            pedalInput.Init();

            tbSource.Minimum = pedalInput.GetInputRange().MinValue;
            tbSource.Maximum = pedalInput.GetInputRange().MaxValue;

            if (pedalOutput == null)
            {
                pedalOutput = new PedalOutput();
                pedalOutput.Init();
            }

            tbOutput.Minimum = pedalOutput.GetOutputRange().MinValue;
            tbOutput.Maximum = pedalOutput.GetOutputRange().MaxValue;

            monitor = new PedalMonitor(pedalInput, pedalOutput);
            monitor.SetTimerCallback(UpdateSignal);
        }

        public void UpdateSignal(int input, int output)
        {
            tbSource.Invoke(new Action(() =>
            {
                tbSource.Value = input;
            }));

            tbOutput.Invoke(new Action(() =>
            {
                tbOutput.Value = output;
            }));
        }

        public void StartMonitor()
        {
            if (SettingsManager.HasInputDeviceConfigured())
            {
                ConfigureTunerParams();
                if (pedalInput.IsAttached())
                {
                    InitPedals();

                    monitor.Start(this.curveFilterType, factor, monitorInterval);
                    isMonitoring = true;
                    lblStatus.Text = "Active";
                    btnMonitor.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("Please make sure your device is attached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please configure your input device first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopMonitor()
        {
            monitor.Stop();
            isMonitoring = false;
            lblStatus.Text = "Idle";
            btnMonitor.Text = "Monitor";
        }

        private void InitInterval()
        {
            if (SettingsManager.HasSettings())
            {
                tbInterval.Text = SettingsManager.settings.MonitorInterval.ToString();
            }
        }

        private void SetInterval(int interval)
        {
            this.monitorInterval = interval;
            SettingsManager.settings.MonitorInterval = interval;
        }

        private void InitFactor()
        {
            if (SettingsManager.HasSettings())
            {
                tbFactor.Text = SettingsManager.settings.FilterFactor.ToString();
            }
        }

        private void SetFactor(double factor)
        {
            this.factor = factor;
            if (monitor != null)
            {
                monitor.SetFactor(factor);
                SettingsManager.settings.FilterFactor = factor;
            }
        }

        public void InitCurveFilterType()
        {
            if (SettingsManager.HasSettings())
            {
                var filterItem = Enum.GetName(SettingsManager.settings.Filter);

                cbFilterType.SelectedItem = filterItem;
            }
        }
        private void SetProfile(CurveFilterType curveFilter)
        {
            tsLabelProfile.Text = $"Filter: {curveFilter.ToString()}";
            this.curveFilterType = curveFilter;

            if (monitor != null)
            {
                monitor.SetCurve(curveFilter);
                SettingsManager.settings.Filter = curveFilter;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void inputDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputDeviceSetup = new InputDeviceSetup();
            inputDeviceSetup.FormClosed += InputDeviceSetup_FormClosed;
            inputDeviceSetup.ShowDialog();

        }

        private void InputDeviceSetup_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //Attempt to InitPedals when form is closed
            InitPedals();
        }

        private void gameSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitPedals();

            var gameSetup = new GameSetup(pedalOutput);
            gameSetup.ShowDialog();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (!isMonitoring)
            {
                StartMonitor();
                SettingsManager.saveSettings();
            }
            else
            {
                StopMonitor();
            }
        }

        private void cbFilterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //SetProfile(Enum.Parse<CurveFilterType>(cbFilterType.SelectedItem.ToString()));
        }

        private void tbInterval_TextChanged(object sender, EventArgs e)
        {
            //SetInterval(int.Parse(tbInterval.Text));
        }

        private void tbFactor_TextChanged(object sender, EventArgs e)
        {
            //SetFactor(double.Parse(tbFactor.Text));
        }

        private void btnSetParams_Click(object sender, EventArgs e)
        {
            ConfigureTunerParams();
        }

        private void ConfigureTunerParams()
        {
            if (Enum.TryParse<CurveFilterType>(cbFilterType.SelectedItem?.ToString(), true, out curveFilterType))
            {
                SetProfile(curveFilterType);
            }

            if (int.TryParse(tbInterval.Text, out monitorInterval))
            {
                SetInterval(monitorInterval);
            }
            else
            {
                tbInterval.Text = "25";
                monitorInterval = 25;
                SetInterval(monitorInterval);
            }

            if (double.TryParse(tbFactor.Text, out factor))
            {
                SetFactor(double.Parse(tbFactor.Text));
            }

            RefreshChart();
        }
    }
}
