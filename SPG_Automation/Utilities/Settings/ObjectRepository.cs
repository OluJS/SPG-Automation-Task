using OpenQA.Selenium;
using SPG_Automation.Utilities.Interfaces;

namespace SPG_Automation.Utilities.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
