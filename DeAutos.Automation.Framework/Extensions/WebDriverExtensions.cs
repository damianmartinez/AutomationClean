using JSErrorCollector;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DeAutos.Automation.Framework.Extensions
{
    public static class WebDriverExtensions
    {
        /// <summary>
        /// Untils the specified driver.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="driver">The driver.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns></returns>
        public static TResult Until<TResult>(this IWebDriver driver, Func<IWebDriver, TResult> condition, TimeSpan timeout)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(condition);
        }

        /// <summary>
        /// Returns a collection of JavaScript errors (a plugin on the browser is needed)
        /// View https://github.com/protectedtrust/JSErrorCollector.NET for more information
        /// </summary>
        /// <param name="driver">The WebDriver instrance</param>
        /// <returns></returns>
        public static IEnumerable<JavaScriptError> GetJavaScriptErrors(this IWebDriver driver)
        {
            return JavaScriptError.ReadErrors(driver);
        }

        /// <summary>
        /// Switch tabs in the specified driver, and leaves it or not at the new one as indicated.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="oldWindow">The old/original window.</param>
        /// <param name="expectedTitle">The expected title of the new window.</param>
        /// <param name="stayOnNewTab">Will the driver remain on the new window, or will it close it going back to the original</param>
        /// <param name="titlePartialMatch">If the expecteTitle should have a partial match or not</param>
        /// <returns></returns>
        /// string oldWindow = driver.CurrentWindowHandle;
        /// driver.FindElement(By.XPath("//*[contains(text(),'Visitá el Catálogo')]/..")).Click();
        /// driver.SwitchTab(oldWindow, "Catálogo de autos", titlePartialMatch: true);

        public static bool SwitchTab(this IWebDriver driver, string oldWindow, string expectedTitle = "", bool stayOnNewTab = true, bool titlePartialMatch = false)
        {
            //Variables para manejo de windows
            string newWindow = null;

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => driver.WindowHandles.Count == 2);

            //busco la nueva window
            var windowHandles = driver.WindowHandles;

            var windows = new ReadOnlyCollection<string>(windowHandles);

            foreach (string window in windows)
            {
                if (window != oldWindow)
                {
                    newWindow = window;
                }
            }

            // switcheo a la nueva window
            driver.SwitchTo().Window(newWindow);

            string newWindowTitle = driver.Title;

            if (!stayOnNewTab)
            {
                // cierro la nueva window
                driver.Close();
                // vuelvo a la vieja window
                driver.SwitchTo().Window(oldWindow);
            }

            if (titlePartialMatch)
                return newWindowTitle.Contains(expectedTitle);

            return newWindowTitle == expectedTitle;
        }

        public static bool IsElementPresent(this IWebDriver driver, By by)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            }
        }

        public static bool CheckJavaScriptError(this IWebDriver driver, string url)
        {
            driver.Url = url;
            Console.WriteLine("Testing: " + url);
            IEnumerable<JavaScriptError> javaScriptErrors = driver.GetJavaScriptErrors();

            bool hasError = false;
            foreach (var x in javaScriptErrors)
            {
                PrintErrorMessage(x);

                if (x.ErrorMessage.Contains("Error:"))
                {
                    hasError = true;
                }
            }
            return hasError;
        }

        private static void PrintErrorMessage(JavaScriptError javaScriptError)
        {
            string message = $"Error/Warning: {javaScriptError.SourceName}, Line: {javaScriptError.LineNumber}, Message: {javaScriptError.ErrorMessage} \n";
            Console.WriteLine(message);
        }

        public static void GoToLastPage(this IWebDriver driver)
        {
            while (driver.IsElementPresent(By.CssSelector("a.nextLink")))
            {
                driver.FindElement(By.CssSelector("a.nextLink")).Click();
            }
        }

        public static void ExecuteJavascript(this IWebDriver driver, string script)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
    }
}