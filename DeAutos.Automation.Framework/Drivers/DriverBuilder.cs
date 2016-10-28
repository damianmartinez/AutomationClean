using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace DeAutos.Automation.Framework.Drivers
{
    public class DriverBuilder
    {
        private IDictionary<Browser, IDictionary<ExecutionMode, Func<IWebDriver>>> config = new Dictionary<Browser, IDictionary<ExecutionMode, Func<IWebDriver>>>();

        /// <summary>
        /// Gets the drivers.
        /// </summary>
        /// <value>
        /// The drivers.
        /// </value>
        public IDictionary<Browser, IDictionary<ExecutionMode, Func<IWebDriver>>> Drivers
        {
            get { return config; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriverBuilder"/> class.
        /// </summary>
        public DriverBuilder()
        {
            config.Add(Browser.Firefox, DriverInit(new FirefoxDriverFactory()));
            config.Add(Browser.Chrome, DriverInit(new ChromeDriverFactory()));
            config.Add(Browser.IE, DriverInit(new InternetExplorerDriverFactory()));
        }

        /// <summary>
        /// Creates the driver factory.
        /// </summary>
        /// <param name="webDriverFactory">The web driver factory.</param>
        /// <returns></returns>
        private IDictionary<ExecutionMode, Func<IWebDriver>> DriverInit(WebDriverFactory webDriverFactory)
        {
            return new Dictionary<ExecutionMode, Func<IWebDriver>>()
            {
                { ExecutionMode.Local, () => { return webDriverFactory.CreateLocal(); } },
                { ExecutionMode.Remote, () => { return webDriverFactory.CreateRemote(); } }
            };
        }
    }
}