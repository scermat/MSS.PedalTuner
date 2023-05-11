using MattScerri.Fanatec.V3.PedalCurve.CurveFilter;
using MattScerri.Fanatec.V3.PedalCurve.Pedal;

namespace MattScerri.Fanatec.V3.PedalCurve
{
    public class SignalFilter
    {
        private RangeScale fromRange;
        private RangeScale toRange;

        public SignalFilter(RangeScale fromRange, RangeScale toRange)
        {
            this.fromRange = fromRange;
            this.toRange = toRange;
        }

        public int Filter(CurveFilterType filterType, int input, double factor)
        {
            switch (filterType)
            {
                case CurveFilterType.Exponential:
                    return (int)ExponentialFilter(input, factor);
                //case CurveFilterType.Log:
                //    return (int)LogarithmicFilter(input, factor);
                case CurveFilterType.Sine:
                    return (int)ButterflyFilter(input, factor);
                default:
                    return (int)LinearFilter(input, factor);
            }
        }

        public double LinearFilter(int input, double factor)
        {
            //return Math.Floor(((double)toRange.MaxValue / (double)fromRange.MaxValue) * input) * factor;
            return Math.Min(input * factor, fromRange.MaxValue);
        }
        public double ExponentialFilter(int input, double factor)
        {
            double maxInput = fromRange.MaxValue;
            return Math.Pow(input / maxInput, factor) * maxInput;
        }

        public double LogarithmicFilter(int input, double factor)
        {
            double maxInput = fromRange.MaxValue;
            double scaleFactor = maxInput / Math.Log(maxInput + 1, factor);
            return Math.Log(input + 1, factor) * scaleFactor;
        }

        public double ButterflyFilter(int input, double scale)
        {
            double maxInput = fromRange.MaxValue;
            return Math.Min(maxInput / 2 * (Math.Sin(input * Math.PI / maxInput - Math.PI / 2) + 1), maxInput);
        }
    }
}
