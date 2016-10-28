using System;

namespace DeAutos.Automation.Framework.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// To the enum.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}