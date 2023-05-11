using MattScerri.Fanatec.V3.PedalCurve.CurveFilter;

namespace MattScerri.Fanatec.V3.PedalCurve.Settings
{
    public class PedalTunerSettings
    {
        public PedalInputSettings InputSettings { get; set; }
        public CurveFilterType Filter { get; set; }
        public double FilterFactor { get; set; }
        public int MonitorInterval { get; set; }
        public PedalTunerSettings()
        {
            InputSettings = new PedalInputSettings();
            Filter = CurveFilterType.Exponential;
            FilterFactor = 1.4;
            MonitorInterval = 100;
        }
    }
}
