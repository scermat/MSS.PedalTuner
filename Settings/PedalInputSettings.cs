namespace MattScerri.Fanatec.V3.PedalCurve.Settings
{
    public class PedalInputSettings
    {
        public List<KeyValuePair<string, Guid>>? devices;
        public Guid? deviceGuid;
        public string? brakeProperty;
        public string brakeMinVal;
        public string brakeMaxVal;
        public bool brakeInvertSignal;
    }
}
