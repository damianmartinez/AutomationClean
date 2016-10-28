using DeAutos.Automation.Framework.Extensions;
using DeAutos.Automation.Framework.Resolver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace DeAutos.Automation.Framework.Drivers
{
    public class Container
    {
        /// <summary>
        /// The default browser
        /// </summary>
        private static Browser DefaultBrowser = Env.DefaultBrowser.ToEnum<Browser>();

        /// <summary>
        /// The execution mode
        /// </summary>
        private static ExecutionMode ExecutionMode = Env.ExecutionMode.ToEnum<ExecutionMode>();

        /// <summary>
        /// The driver builder
        /// </summary>
        private static DriverBuilder DriverBuilder = new DriverBuilder();

        /// <summary>
        /// Initializes the <see cref="Container"/> class.
        /// </summary>
        static Container()
        {
        }

        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <returns></returns>
        public static IWebDriver Resolve()
        {
            return GetDriver(DefaultBrowser, ExecutionMode);
        }

        /// <summary>
        /// Gets the driver.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <param name="executionMode">The execution mode.</param>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">
        /// This environment is not supported.
        /// or
        /// This browser is not supported.
        /// </exception>
        private static IWebDriver GetDriver(Browser browser, ExecutionMode executionMode)
        {
            if (DriverBuilder.Drivers.ContainsKey(browser))
            {
                IDictionary<ExecutionMode, Func<IWebDriver>> driver = DriverBuilder.Drivers[browser];
                if (driver.ContainsKey(executionMode))
                {
                    Func<IWebDriver> webDriver = driver[executionMode];
                    return webDriver();
                }
                throw new ApplicationException("This environment is not supported. ");
            }
            throw new ApplicationException("This browser is not supported.");
        }
    }
}