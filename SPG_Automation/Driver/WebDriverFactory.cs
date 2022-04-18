using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SPG_Automation.Utilities.Configuration;
using SPG_Automation.Utilities.CustomExceptions;
using SPG_Automation.Utilities.Settings;

namespace SPG_Automation
{
    public class WebDriverFactory
    {
        // Manipulating properties of Chrome driver
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("incognito");
            return options;
        }

        public static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        /*
         * Calling the method to initialise webdriver to use
         * based on browser chosen in config
         */
        public static void InitWebDriver()
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound($"Driver not found");
            }
        }
    }
}
