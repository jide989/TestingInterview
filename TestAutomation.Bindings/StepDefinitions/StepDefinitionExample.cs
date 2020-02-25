using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestAutomation.Bindings.Contexts;
using TestAutomation.PageObjects.Factories;

namespace TestAutomation.Bindings.StepDefinitions
{
    [Binding]
    public class StepDefinitionExample : BaseSteps
    {
        public StepDefinitionExample(IPageObjectFactory pageObjectFactory, PageContext pageContext) : base(pageObjectFactory, pageContext)
        {
        }

        [Given(@"the Login page has been loaded")]
        public void GivenTheLoginPageHasBeenLoaded()
        {
            PageContext.LoginPage = PageObjectFactory.CreateLoginPage().Navigate();
        }

        [When(@"I log in with with the following details:")]
        public void WhenILogInWithWithTheFollowingDetails(Table table)
        {
            var loginDetails = table.CreateInstance<LoginDetails>();

            // TODO: Finish the implementation using the data from the Specflow Table and using Chaining to get from one page to the next
            // PageContext.SecureAreaPage = PageContext.
        }

        [Then(@"I should be on a page titled '(.*)'")]
        public void ThenIShouldBeOnAPageTitled(string pageTitle)
        {
            // TODO: Assert that the page title text is on the SecureAreaPage
        }
    }
}
