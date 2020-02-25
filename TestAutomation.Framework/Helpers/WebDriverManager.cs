using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Framework.Interfaces;

namespace TestAutomation.Framework.Helpers
{
    public class WebDriverManager : IWebDriverManager
    {
        public WebDriverManager(IWebDriver webDriver, WebDriverWait webDriverWait)
        {
            WebDriver = webDriver;
            WebDriverWait = webDriverWait;
        }

        public IWebDriver WebDriver { get; set; }
        public WebDriverWait WebDriverWait { get; set; }
        public string RootUrl { get; set; }
    }
}
