using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SPG_Automation.Utilities.Common;
using SPG_Automation.Utilities.CustomExceptions;
using SPG_Automation.Utilities.Helpers;
using SPG_Automation.Utilities.Settings;
using System;

namespace SPG_Automation
{
    public abstract class BasePage
    {

        public abstract void WaitToLoad(double timeOut = BDDConstants.PageLoadDefault);

        public bool WaitUntil_ElementIsInvisible(string selector, double timeOut)
        {
            try
            {
                new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(timeOut)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(selector)));
                return true;
            }
            catch
            {
                throw new ElementNotInvisible($"The element was not invisible after waiting {timeOut} seconds");
            }
        }

        public bool WaitUntil_ElementIsVisible(string selector, double timeOut)
        {
            try
            {
                new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(timeOut)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(selector)));
                return true;
            }
            catch
            {
                throw new ElementNotVisibleException($"{selector} was not visible after waiting {timeOut} seconds");
            }
        }

        public void NavigateToUrl(string url)
        {
            if (ReadJSON.ReadPageURLs(url) != null)
            {
                ObjectRepository.Driver.Navigate().GoToUrl(ReadJSON.ReadPageURLs(url));
            }
            else
            {
                throw new ElementNotFoundInJSON($"Unable to find the url named: '{url}' in {ReadJSON.PageUrlsFileName}");
            }
        }

        public void Click(string locator)
        {
            if (ReadJSON.ReadPageElementSelectors(locator) != null)
            {
                ObjectRepository.Driver.FindElement(By.CssSelector(ReadJSON.ReadPageElementSelectors(locator))).Click();
            }
            else
            {
                throw new ElementNotFoundInJSON($"Unable to find the locator: '{locator}' in {ReadJSON.ElementSelctorsFileName}");
            }
        }
    }
}
