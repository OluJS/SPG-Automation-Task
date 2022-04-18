using OpenQA.Selenium;
using SPG_Automation.Utilities.Common;
using SPG_Automation.Utilities.Settings;

namespace SPG_Automation.PageObjects
{
    public class DotNetFiddlePage : BasePage
    {
        public IWebElement OutputWindow => ObjectRepository.Driver.FindElement(By.CssSelector("#output"));

        public void GoToPage(string pageName)
        {
            NavigateToUrl(pageName);
        }

        public void ClickOnButton(string button)
        {
            Click(button);
        }

        public string CheckOutputWindow()
        {
            return OutputWindow.Text;
        }

        public bool CheckIfOptionsPanelIsHidden()
        {
            return WaitUntil_ElementIsInvisible("button[class='btn btn-default btn-xs btn-sidebar-toggle']", BDDConstants.ElementLoadDefault);
        }

        public override void WaitToLoad(double timeOut = BDDConstants.PageLoadDefault)
        {
            WaitUntil_ElementIsVisible(".stats-pane.pane", timeOut);
        }
    }
}
