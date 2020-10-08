using System.Configuration;

namespace CustomConfigSection.Settings
{
    public class OfflineMode : ConfigurationElement
    {
        [ConfigurationProperty("isConnected", IsKey = true, IsRequired = true)]
        public bool IsConnected
        {
            get => (bool)base["isConnected"];
            set => base["isConnected"] = value;
        }

        [ConfigurationProperty("isReady", IsKey = true, IsRequired = true)]
        public bool IsReady
        {
            get => (bool)base["isReady"];
            set => base["isReady"] = value;
        }

        [ConfigurationProperty("subSystems", IsRequired = false)]
        [ConfigurationCollection(typeof(TrafficLightSubSystemCollection))]
        public TrafficLightSubSystemCollection SubSystemCollection
        {
            get => (TrafficLightSubSystemCollection)this["subSystems"];
        }
    }
}