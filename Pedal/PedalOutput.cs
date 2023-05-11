using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;

namespace MattScerri.Fanatec.V3.PedalCurve.Pedal
{
    //TODO: Needs to be singleton
    public class PedalOutput
    {
        private ViGEmClient vigemClient;
        private IXbox360Controller emulatedController;

        private int pedalValue = 0;

        RangeScale outputRangeScale;

        public PedalOutput()
        {
            //Hardcode for Xbox Trigger for now;
            outputRangeScale = new RangeScale(0, 255);
        }

        public void Init()
        {
            if (vigemClient == null)
            {
                vigemClient = new ViGEmClient();
            }

            if (emulatedController == null)
            {
                emulatedController = vigemClient.CreateXbox360Controller();
                emulatedController.AutoSubmitReport = false;

                emulatedController.Connect();
            }
        }

        public void SetOutput(RangeScale inputRangeScale, int rawFilteredOutput)
        {
            //Rescale to XAxis
            var brakeOutput = (int)inputRangeScale.Rescale(outputRangeScale, rawFilteredOutput);

            pedalValue = brakeOutput;

            byte filteredBrakeValue = (byte)brakeOutput;

            // Set the filtered brake input value to the emulated controller's right trigger
            emulatedController.SetSliderValue(Xbox360Slider.RightTrigger, filteredBrakeValue);
            emulatedController.SubmitReport();
        }

        public int GetPedalValue()
        {
            return pedalValue;
        }

        public void ForceOutput(int value)
        {
            emulatedController.SetSliderValue(Xbox360Slider.RightTrigger, (byte)value);
            emulatedController.SubmitReport();
        }

        public RangeScale GetOutputRange()
        {
            return outputRangeScale;
        }
    }
}
