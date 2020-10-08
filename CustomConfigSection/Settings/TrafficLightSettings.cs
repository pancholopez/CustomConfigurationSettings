using System.Configuration;

namespace CustomConfigSection.Settings
{
    public class TrafficLightSettings : ConfigurationSection
    {
        public static TrafficLightSettings Settings => ConfigurationManager.GetSection("trafficLightSettings") as TrafficLightSettings;

        [ConfigurationProperty("isFeatureEnabled", DefaultValue = false, IsRequired = false)]
        public bool IsFeatureEnabled
        {
            get => (bool) this["isFeatureEnabled"];
            set => this["isFeatureEnabled"] = value;
        }

        [ConfigurationProperty("useOfflineMode", DefaultValue = false, IsRequired = false)]
        public bool UseOfflineMode
        {
            get => (bool)this["useOfflineMode"];
            set => this["useOfflineMode"] = value;
        }

        [ConfigurationProperty("offlineMode", IsRequired = false)]
        public OfflineMode OfflineMode
        {
            get => (OfflineMode) this["offlineMode"];
        }
    }
}