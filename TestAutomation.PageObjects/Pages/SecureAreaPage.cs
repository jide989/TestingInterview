using OpenQA.Selenium;
using TestAutomation.Framework.BasePages;
using TestAutomation.Framework.Interfaces;

namespace TestAutomation.PageObjects.Pages
{
    public class SecureAreaPage : BasePage<SecureAreaPage>
    {
        public SecureAreaPage(IWebDriverManager webDriverManager) : base(webDriverManager)
        {
        }

        // TODO: Find the heading element and retrieve the text from it
        // protected IWebElement Heading => WebDriver.FindElement();

        // TODO Create a method to get the heading text as a string, that can be used by the bindings for assertion
    }
}
