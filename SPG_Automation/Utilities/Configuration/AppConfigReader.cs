using SPG_Automation.Utilities.Interfaces;
using SPG_Automation.Utilities.Settings;
using System;
using System.Configuration;

namespace SPG_Automation.Utilities.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            /*
             * To find the config file being used
             * string path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath;
             */

            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }
    }
}
