using System;

namespace DeAutos.Automation.Framework.Extensions
{
    public static class StringExtensions
    {
        public static string GenerateEmail(this string prefix)
        {
            var dateTime = DateTime.Now.ToString("ddhhmmss");

            return string.Concat("qadeautos+", prefix, dateTime, "@gmail.com");
        }
    }
}