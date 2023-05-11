namespace MattScerri.Fanatec.V3.PedalCurve.CurveFilter
{
    public static class CurveFilterHelper
    {
        public static CurveFilterType CurveFilterLookup(string item)
        {
            if (item.ToLowerInvariant() == "exponential")
            {
                return CurveFilterType.Exponential;
            }
            //else if (item.ToLowerInvariant() == "logarithmic")
            //{
            //    return CurveFilterType.Log;
            //}
            else if (item.ToLowerInvariant() == "butterfly")
            {
                return CurveFilterType.Sine;
            }

            return CurveFilterType.Linear;
        }
    }
}