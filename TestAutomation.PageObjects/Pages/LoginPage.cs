using OpenQA.Selenium;
using TestAutomation.Framework.BasePages;
using TestAutomation.Framework.Interfaces;

namespace TestAutomation.PageObjects.Pages
{
    public class LoginPage : BasePage<LoginPage>
    {
        internal LoginPage(IWebDriverManager webDriverManager) : base(webDriverManager)
        {
        }

        // TODO: Find other relevant elements required to login
        // private IWebElement LoginButton => WebDriver.FindElement();

        public LoginPage Navigate()
        {
            WebDriverManager.WebDriver.Navigate().GoToUrl(WebDriverManager.RootUrl);
            return this;
        }

        // TODO: Write a public method to be used by the Bindings to login to the Secure Area Page
    }
}
