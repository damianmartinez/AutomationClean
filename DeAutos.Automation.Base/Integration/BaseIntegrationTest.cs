using DeAutos.Automation.Framework.Drivers;
using DeAutos.Automation.Framework.Resolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace DeAutos.Automation.Integration.Integration
{
    [TestClass]
    public class BaseIntegrationTest : BaseTest
    {
        protected IWebDriver driver;

        [TestInitialize]
        public virtual void SetUp()
        {
            driver = Container.Resolve();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Env.TimeoutImplicitWaitSeconds));
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}