using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Framework.Interfaces;

namespace TestAutomation.Framework.BasePages
{
    public abstract class BasePage<T>
    {
        private const string ReadyStateJavascript = "return document.readyState";

        protected BasePage(IWebDriverManager webDriverManager)
        {
            WebDriverManager = webDriverManager;
            PageUrl = WebDriver.Url;
        }

        public bool IsPageInReadyState
        {
            get
            {
                try
                {
                    return WebDriver.ExecuteJavaScript<string>(ReadyStateJavascript).Equals("complete");
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }

        public string PageUrl;

        protected IWebDriverManager WebDriverManager { get; }
        protected IWebDriver WebDriver => WebDriverManager.WebDriver;
        protected WebDriverWait WebDriverWait => WebDriverManager.WebDriverWait;
    }
}
