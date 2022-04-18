using SPG_Automation.PageObjects;
using SPG_Automation.Utilities.Settings;
using TechTalk.SpecFlow;

namespace SPG_Automation.Hooks
{
    [Binding]
    public class Hooks
    {
        public DotNetFiddlePage _dotNetFiddlePage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriverFactory.InitWebDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}