using JSErrorCollector;
using NDesk.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeAutos.Automation.Runner
{
    public class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            OptionSet optionSet = new OptionSet();
            try
            {
                optionSet.Add("h|?|help", (help) => ShowHelp(help));
                optionSet.Add("js|javascript=", (url) => CheckErrors(url));
                optionSet.Parse(args);
                Environment.Exit(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Checks the errors.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <exception cref="System.ApplicationException"></exception>
        private static void CheckErrors(string url)
        {
            FirefoxProfile profile = new FirefoxProfile();
            DesiredCapabilities capabilities = DesiredCapabilities.Firefox();
            profile.SetPreference("toolkit.startup.max_resumed_crashes", "-1");

            capabilities.SetCapability(FirefoxDriver.ProfileCapabilityName, profile.ToBase64String());

            JavaScriptError.AddExtension(profile);
            IWebDriver driver = new FirefoxDriver(profile);

            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().Refresh();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));

            driver.Url = url;
            Console.WriteLine("Analysing errors...");
            IList<JavaScriptError> clientSideErrors = JavaScriptError.ReadErrors(driver);

            driver.Quit();

            if (clientSideErrors.Any())
            {
                foreach (JavaScriptError error in clientSideErrors)
                {
                    Console.WriteLine(error);
                }
                throw new ApplicationException($"There are {clientSideErrors.Count()} javascript errors. ");
            }
            Console.WriteLine("No errors found. ");
        }

        /// <summary>
        /// Shows the help.
        /// </summary>
        /// <param name="message">The message.</param>
        private static void ShowHelp(string message)
        {
            Console.WriteLine("Options: ");
            Console.WriteLine("\t--javascript={url}");
        }
    }
}