using OpenQA.Selenium;
using System;

namespace DeAutos.Automation.Framework.DTO
{
    public class InputDto
    {
        public Func<string, By> Function { get; set; }

        public string Value { get; set; }
    }
}