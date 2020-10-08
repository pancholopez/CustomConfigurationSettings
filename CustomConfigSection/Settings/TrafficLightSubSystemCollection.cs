using System.Configuration;

namespace CustomConfigSection.Settings
{
    public class TrafficLightSubSystemCollection : ConfigurationElementCollection
    {
        public TrafficLightSubSystemElement this[int index]
        {
            get => (TrafficLightSubSystemElement)BaseGet(index);
            set
            {
                if (BaseGet(index) != null) BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }

        public new TrafficLightSubSystemElement this[string key]
        {
            get => (TrafficLightSubSystemElement)BaseGet(key);
            set
            {
                if (BaseGet(key) != null) BaseRemoveAt(BaseIndexOf(BaseGet(key)));
                BaseAdd(value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new TrafficLightSubSystemElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((TrafficLightSubSystemElement)element).Name;
        }
    }
}