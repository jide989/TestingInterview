using System;
using NUnit.Framework;
using TestAutomation.Framework.Interfaces;

namespace TestAutomation.Framework.Factories
{
    public class WebDriverFactoryRegistry
    {
        public IWebDriverFactory GetWebDriver(string browser)
        {
            var webDriverTimeout = TimeSpan.Parse(TestContext.Parameters["WebDriverTimeout"]);

            switch (browser.ToLower())
            {
                case "firefox":
                    return new FireFoxDriverFactory
                    {
                        WebDriverTimeout = webDriverTimeout
                    };

                case "chrome":
                    return new ChromeDriverFactory
                    {
                        WebDriverTimeout = webDriverTimeout
                    };

                case "ie":
                    return new InternetExplorerDriverFactory();

                default:
                    return new ChromeDriverFactory
                    {
                        WebDriverTimeout = webDriverTimeout
                    };
            }
        }
    }
}
