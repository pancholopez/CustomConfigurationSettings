using System;
using System.Text;
using CustomConfigSection.Settings;

namespace CustomConfigSection
{
    class Program
    {
        /// <summary>
        /// https://ivankahl.com/creating-custom-configuration-sections-in-app-config/
        /// https://haacked.com/archive/2007/03/12/custom-configuration-sections-in-3-easy-steps.aspx/
        /// </summary>
        static void Main(string[] args)
        {
            var settings = TrafficLightSettings.Settings;

            var sb = new StringBuilder();
            sb.AppendLine("[TrafficLightService]");
            sb.AppendLine($"IsFeatureEnabled = {settings.IsFeatureEnabled}");
            sb.AppendLine($"UseOfflineMode = {settings.UseOfflineMode}");
            sb.AppendLine();
            sb.AppendLine("[OfflineMode]");
            sb.AppendLine($"IsConnected = {settings.OfflineMode.IsConnected}");
            sb.AppendLine($"IsReady = {settings.OfflineMode.IsReady}");
            sb.AppendLine();
            sb.AppendLine("[Components]");
            foreach (TrafficLightSubSystemElement subSystem in settings.OfflineMode.SubSystemCollection)
            {
                sb.AppendLine($"Name = {subSystem.Name}");
                sb.AppendLine($"IsReady = {subSystem.IsReady}");
                sb.AppendLine($"Components = {subSystem.Components}");
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
