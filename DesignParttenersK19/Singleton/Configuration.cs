using System.Collections.Generic;

namespace DesignParttenersK19.Singleton
{
    public class Configuration
    {
        private static Configuration _configurationInstance;
        public Dictionary<string, string> Settings { get; set; }

        public Configuration()
        {
            // Load Configurations from some place.
        }

        public static Configuration Instance()
        {
            return _configurationInstance ?? (_configurationInstance = new Configuration());
        }

        public string Property(string nomeDaPropriedade)
        {
            return this.Settings[nomeDaPropriedade];
        }
    }
}