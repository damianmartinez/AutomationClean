using OpenQA.Selenium;
using System;

namespace DeAutos.Automation.Framework.Conditions
{
    public class ExpectedConditionsCustom
    {
        private const bool Debug = true;

        public static Func<IWebDriver, bool> ElementCssValueEquals(By locator, string cssValue, string expectedValue)
        {
            return (driver) =>
            {
                var actualValue = driver.FindElement(locator).GetCssValue(cssValue);

                Console.WriteLine($"Elemento: '{locator}' tiene que tener en el CSS: '{cssValue}' un valor: '{expectedValue}' y vale: '{actualValue}'");
                return actualValue.Equals(expectedValue);
            };
        }

        public static Func<IWebDriver, bool> ElementIsNotVisible(By locator)
        {
            return (driver) => !(driver.FindElement(locator).Displayed);
        }
    }
}