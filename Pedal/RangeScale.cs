namespace MattScerri.Fanatec.V3.PedalCurve.Pedal
{
    public class RangeScale
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public RangeScale(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public int GetSignalRange()
        {
            return Math.Abs(MaxValue - MinValue);
        }
    }

    public static class RangeScaleHelper
    {
        public static double Rescale(this RangeScale oldScale, RangeScale newScale, int value)
        {
            // Ensure the old range is not zero to avoid division by zero
            if (oldScale.MaxValue - oldScale.MinValue == 0)
            {
                throw new ArgumentException("Old range cannot be zero.");
            }

            // Calculate the scaling factor
            double scaleFactor = (newScale.MaxValue - newScale.MinValue) / (double)(oldScale.MaxValue - oldScale.MinValue);

            // Rescale the value
            return newScale.MinValue + (value - oldScale.MinValue) * scaleFactor;
        }
    }
}
