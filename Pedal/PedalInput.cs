using SharpDX.DirectInput;

namespace MattScerri.Fanatec.V3.PedalCurve.Pedal
{
    public class PedalInput
    {
        private Guid deviceId = Guid.Empty;

        private DirectInput directInput;
        private Joystick pedalsController;

        private RangeScale inputRangeScale;

        private string propertyIdentifier = string.Empty;

        private bool bInvertSignal = false;

        public PedalInput(Guid deviceId, string propertyIdentifier, int brakeMinVal, int brakeMaxVal, bool bInvertSignal)
        {
            this.deviceId = deviceId;
            this.propertyIdentifier = propertyIdentifier;

            inputRangeScale = new RangeScale(brakeMinVal, brakeMaxVal);
            this.bInvertSignal = bInvertSignal;
        }

        public void Init()
        {
            directInput = new DirectInput();

            // Initialize the joystick object
            if (IsAttached())
            {
                pedalsController = new Joystick(directInput, deviceId);
                pedalsController.Properties.BufferSize = 128;
                pedalsController.Acquire();
            }
            else
            {
                MessageBox.Show("Unable to find device. Please make sure it is connected.", "Error initialising device", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsAttached()
        {
            return directInput.IsDeviceAttached(deviceId);
        }

        public RangeScale GetInputRange()
        {
            return inputRangeScale;
        }

        public int GetPedalInputValue()
        {
            pedalsController.Poll();
            var state = pedalsController.GetCurrentState();

            var rawValue = (int)state.GetType().GetProperty(propertyIdentifier).GetValue(state);

            var inputValue = rawValue;

            if (bInvertSignal)
            {
                inputValue = invertSignal(rawValue);
            }

            return inputValue;
        }

        /// <summary>
        /// Used for pedals that go down in scale rather than up, e.g. Fanatec v3s position 
        /// is at 65535 when there is 0 pressure and 0 when there is max pressure
        /// </summary>
        /// <returns></returns>
        private int invertSignal(int rawValue)
        {
            return rawValue * -1 + inputRangeScale.MaxValue;
        }

        private object getValueFromStateProperty(JoystickState joystickState, string propertyName)
        {
            return joystickState.GetType().GetProperty(propertyName).GetValue(joystickState);
        }
    }
}
