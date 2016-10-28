using System.Collections.Specialized;
using System.Configuration;

namespace DeAutos.Automation.Framework.Resolver
{
    public class Env
    {
        private static NameValueCollection settings = (NameValueCollection)ConfigurationManager.GetSection("generalConfiguration/EnvironmentConfiguration");
        public static string RemoteAddress = settings.Get("RemoteAddress");
        public static string AutomationHost = settings.Get("AutomationHost");
        public static string TempFolder = settings.Get("TempFolder");
        public static string ChromePath = settings.Get("pluginPathChrome");
        public static string DefaultBrowser = settings.Get("DefaultBrowser");
        public static string ExecutionMode = settings.Get("ExecutionMode");
        public static string ScreenshotFolder = settings.Get("ScreenshotFolder");
        public static int TimeoutImplicitWaitSeconds = int.Parse(settings.Get("Timeout.ImplicitWait.Seconds"));
        public static int MaxInputTries = int.Parse(settings.Get("maxInputTries"));
        public static string BrowserExtensionsFolder = settings.Get("BrowserExtensionsFolder");
        public static string PluginPath = settings.Get("PluginPath");
        public static string ImagesPublish = settings.Get("ImagesPublish");
        public static string ImagesSponsor = settings.Get("ImagesSponsor");

        private Env()
        {
        }
    }
}