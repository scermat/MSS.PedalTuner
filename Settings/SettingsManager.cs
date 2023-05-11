using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace MattScerri.Fanatec.V3.PedalCurve.Settings
{
    public static class SettingsManager
    {
        public static PedalTunerSettings settings = new PedalTunerSettings();

        private static string fileName = "pedaltuner.settings.json";

        [ModuleInitializer]
        public static void Init()
        {
            LoadSettings();
        }

        public static bool HasSettings()
        {
            return SettingsManager.settings != null;
        }

        public static bool HasInputDeviceConfigured()
        {
            return HasSettings() && SettingsManager.settings.InputSettings.deviceGuid != null && !string.IsNullOrEmpty(SettingsManager.settings.InputSettings.brakeProperty) && SettingsManager.settings.InputSettings.brakeMinVal != null && SettingsManager.settings.InputSettings.brakeMaxVal != null;
        }

        public static void LoadSettings()
        {
            if (File.Exists(fileName))
            {
                try
                {
                    settings = JsonConvert.DeserializeObject<PedalTunerSettings>(File.ReadAllText(fileName));

                    if (settings == null)
                    {
                        settings = new PedalTunerSettings();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Failed to load settings from {fileName} with error {e.Message}", "Unable to load settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void saveSettings()
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }
    }
}
