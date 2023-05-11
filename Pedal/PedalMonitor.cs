using MattScerri.Fanatec.V3.PedalCurve.CurveFilter;

namespace MattScerri.Fanatec.V3.PedalCurve.Pedal
{
    public class PedalMonitor
    {
        private System.Timers.Timer timer;
        private PedalInput pedalInput;
        private PedalOutput pedalOutput;
        private int interval;
        private SignalFilter signalFilter;
        private CurveFilterType curveFilterType;
        private double factor;

        public delegate void SignalUpdate(int input, int output);
        public SignalUpdate signalUpdateCallback;

        public PedalMonitor(PedalInput input, PedalOutput output)
        {
            pedalInput = input;
            pedalOutput = output;

            signalFilter = new SignalFilter(input.GetInputRange(), output.GetOutputRange());
        }

        public int SampleSignal(int value, double factor)
        {
            return signalFilter.Filter(curveFilterType, value, this.factor);
        }

        public void Start(CurveFilterType curveFilter, double factor, int interval)
        {
            if (pedalInput.IsAttached())
            {
                curveFilterType = curveFilter;
                this.interval = interval;
                this.factor = factor;

                timer = new System.Timers.Timer();
                timer.Interval = interval;
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
            else
            {
                MessageBox.Show("Unable to start monitoring as device is not attached.", "Error initialising", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetCurve(CurveFilterType curveFilter)
        {
            curveFilterType = curveFilter;
        }

        public void SetFactor(double factor)
        {
            this.factor = factor;
        }

        public void SetTimerCallback(SignalUpdate callback)
        {
            signalUpdateCallback = callback;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (pedalInput.IsAttached())
            {
                var pedalInputValue = pedalInput.GetPedalInputValue();

                var rawFilteredSignal = signalFilter.Filter(curveFilterType, pedalInputValue, factor);

                pedalOutput.SetOutput(pedalInput.GetInputRange(), rawFilteredSignal);

                if (signalUpdateCallback != null)
                {
                    signalUpdateCallback(pedalInputValue, pedalOutput.GetPedalValue());
                }
            }
        }

        public void Stop() { if (timer != null) { timer.Stop(); } }

    }
}
