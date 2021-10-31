using System;
using Newtonsoft.Json;

namespace MinecraftDatapackStudio.Data {
    public class SettingsProvider {
        public static AppPreferences Preferences;

        public static bool LoadSettings() {
            string settings = Properties.Settings.Default["SettingsJSON"].ToString();

            if (!string.IsNullOrEmpty(settings) && !string.IsNullOrWhiteSpace(settings)) {
                Preferences = JsonConvert.DeserializeObject<AppPreferences>(settings);
            } else {
                return false;
            }

            return true;
        }

        public static bool FlushSettings() {
            try {
                string settingsJson = JsonConvert.SerializeObject(Preferences);

                Utilities.PutConfig(settingsJson);

                return true;
            } catch (Exception) {
                return false;
            }
        }
    }
}
