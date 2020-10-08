using System.Configuration;

namespace CustomConfigSection.Settings
{
    public class TrafficLightSubSystemElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get => (string)base["name"];
            set => base["name"] = value;
        }

        [ConfigurationProperty("isReady", IsKey = true, IsRequired = false, DefaultValue = true)]
        public bool IsReady
        {
            get => (bool)base["isReady"];
            set => base["isReady"] = value;
        }

        [ConfigurationProperty("components", IsKey = true, IsRequired = false)]
        public string Components
        {
            get => (string)base["components"];
            set => base["isReady"] = value;
        }
    }
}