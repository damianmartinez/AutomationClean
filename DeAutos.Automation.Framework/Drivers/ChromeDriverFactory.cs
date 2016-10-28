using DeAutos.Automation.Framework.Resolver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace DeAutos.Automation.Framework.Drivers
{
    public class ChromeDriverFactory : WebDriverFactory
    {
        private ChromeOptions options = new ChromeOptions();
        public ChromeDriverFactory()
        {
            options.AddArguments("incognito");
        }

        /// <summary>
        /// Creates the local.
        /// </summary>
        /// <returns></returns>
        public override IWebDriver CreateLocal()
        {
            return new ChromeDriver(Env.ChromePath, options);
        }

        /// <summary>
        /// Creates the remote.
        /// </summary>
        /// <returns></returns>
        public override IWebDriver CreateRemote()
        {
            return new RemoteWebDriver(new Uri(RemoteAddress), DesiredCapabilities.Chrome());
        }
    }
}