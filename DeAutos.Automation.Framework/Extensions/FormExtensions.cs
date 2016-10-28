using DeAutos.Automation.Framework.DTO;
using DeAutos.Automation.Framework.Resolver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeAutos.Automation.Framework.Extensions
{
    public static class FormExtensions
    {
        public static bool FillForm(this IWebDriver driver, IDictionary<string, InputDto> elements)
        {
            int maxInputTries = Env.MaxInputTries;

            while (0 < maxInputTries)
            {
                foreach (KeyValuePair<string, InputDto> item in elements)
                {
                    string key = item.Key;

                    InputDto inputDto = item.Value;
                    string value = inputDto.Value;

                    driver.FindElement(inputDto.Function(key)).Clear();
                    driver.FindElement(inputDto.Function(key)).SendKeys(value);
                }

                bool noErrors = true;
                int field = 0;
                while (field < elements.Count && noErrors)
                {
                    string key = elements.Keys.ElementAt(field);

                    InputDto inputDto = elements.Values.ElementAt(field);
                    string value = inputDto.Value;

                    noErrors = driver.FindElement(inputDto.Function(key)).GetAttribute("value").Equals(value);

                    if (!noErrors)
                    {
                        Console.WriteLine("\nEn el intento nro " + (Env.MaxInputTries - maxInputTries + 1).ToString() +
                            "\nEl By " + inputDto.Function.Method.ToString() + "(" + key.ToString() +
                            ") contiene el string \n'" + driver.FindElement(inputDto.Function(key)).GetAttribute("value") + "'" +
                            "\nCuando tenía que ser igual a\n'" + value + "'");
                    }

                    field++;
                }

                if (noErrors)
                {
                    return true;
                }

                maxInputTries--;
            }

            Console.WriteLine("\nError de Input en \n" + driver.Url + "\n");

            return false;
        }
    }
}