using DeAutos.Automation.Framework.Resolver;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace DeAutos.Automation.Framework.Drivers
{
    public class FirefoxDriverFactory : WebDriverFactory
    {
        private FirefoxProfile profile = new FirefoxProfile();
        private DesiredCapabilities capabilities = DesiredCapabilities.Firefox();
        private static string PluginPath = string.Concat(Env.AutomationHost, Env.BrowserExtensionsFolder, Env.PluginPath);

        /// <summary>
        /// Initializes a new instance of the <see cref="FirefoxDriverFactory"/> class.
        /// </summary>
        public FirefoxDriverFactory()
        {
            profile.SetPreference("toolkit.startup.max_resumed_crashes", "-1");

            profile.AddExtension(PluginPath);

            capabilities.SetCapability(FirefoxDriver.ProfileCapabilityName, profile.ToBase64String());
            capabilities.SetCapability("marionette", true);
        }

        ///// <summary>
        /// Creates the local.
        /// </summary>
        /// <returns></returns>
        public override IWebDriver CreateLocal()
        {
            return new FirefoxDriver(profile);
        }

        /// <summary>
        /// Creates the remote.
        /// </summary>
        /// <returns></returns>
        public override IWebDriver CreateRemote()
        {
            return new RemoteWebDriver(new Uri(RemoteAddress), capabilities);
        }
    }
}