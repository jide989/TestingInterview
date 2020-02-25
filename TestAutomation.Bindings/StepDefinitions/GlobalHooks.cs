using System;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TestAutomation.Framework.Factories;
using TestAutomation.Framework.Helpers;
using TestAutomation.Framework.Interfaces;
using TestAutomation.PageObjects.Factories;

namespace TestAutomation.Bindings.StepDefinitions
{
    [Binding]
    public class GlobalHooks
    {
        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer)
        {
            // Spins up the web browser. Browser type, WebDriverTimout and SiteUrl all specified in the test.runsettings file
            var driver = new WebDriverFactoryRegistry().GetWebDriver(TestContext.Parameters["Browser"]).Create();
            var wait = new WebDriverWait(driver, TimeSpan.Parse(TestContext.Parameters["WebDriverTimeout"]));
            var webDriverManager = new WebDriverManager(driver, wait) { RootUrl = TestContext.Parameters["SiteUrl"] };

            // Here we register the IWebDriverManager Interface using Specflow's context injection (IObjectContainer)
            objectContainer.RegisterInstanceAs<IWebDriverManager>(webDriverManager);
            objectContainer.RegisterTypeAs<PageObjectFactory, IPageObjectFactory>();
        }

        [AfterScenario]
        public static void AfterScenario(IObjectContainer objectContainer)
        {
            try
            {
                objectContainer.Resolve<WebDriverManager>().WebDriver.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
