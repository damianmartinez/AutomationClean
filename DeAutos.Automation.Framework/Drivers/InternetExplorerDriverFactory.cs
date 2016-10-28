using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace DeAutos.Automation.Framework.Drivers
{
    public class InternetExplorerDriverFactory : WebDriverFactory
    {
        /// <summary>
        /// Creates the local.
        /// </summary>
        /// <returns></returns>
        public override IWebDriver CreateLocal()
        {
            return new InternetExplorerDriver();
        }

        /// <summary>
        /// Creates the remote.
        /// </summary>
        /// <returns></returns>
        public override IWebDriver CreateRemote()
        {
            return new RemoteWebDriver(new Uri(RemoteAddress), DesiredCapabilities.InternetExplorer());
        }
    }
}