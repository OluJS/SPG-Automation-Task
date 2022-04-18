using NUnit.Framework;
using SPG_Automation.PageObjects;
using TechTalk.SpecFlow;

namespace SPG_Automation.StepDefinitions
{
    [Binding]
    public class DotNetFiddlePageSteps
    {
        private readonly DotNetFiddlePage _dotNetFiddlePage;
        public DotNetFiddlePageSteps(DotNetFiddlePage dotNetFiddlePage)
        {
            _dotNetFiddlePage = dotNetFiddlePage;
        }

        [Given(@"a user goes to the (.*) website")]
        public void AUserGoesToAWebsite(string webPage)
        {
            _dotNetFiddlePage.GoToPage(webPage.ToLower().Replace(" ", "_"));
            _dotNetFiddlePage.WaitToLoad();
        }

        [When(@"a user clicks the (.*) button")]
        public void AUserClicksTheActionButton(string element)
        {
            _dotNetFiddlePage.ClickOnButton(element.ToLower().Replace(" ", "_"));
        }

        [Then(@"the output window displays '(.*)'")]
        public void TheOutputWindowDisplays(string output)
        {
            string response = _dotNetFiddlePage.CheckOutputWindow();
            Assert.AreEqual(output, response, $"The expected output was '{output}', but received '{response}' instead");
        }

        [Then(@"the Options Panel should be hidden")]
        public void TheElementShouldBeHidden()
        {
            bool response = _dotNetFiddlePage.CheckIfOptionsPanelIsHidden();
            Assert.IsTrue(response, $"The element was not hidden, as a '{response}' response was recieved");
        }
    }
}
