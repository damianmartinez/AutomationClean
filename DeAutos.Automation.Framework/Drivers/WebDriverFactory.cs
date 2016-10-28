using DeAutos.Automation.Framework.Resolver;
using OpenQA.Selenium;

namespace DeAutos.Automation.Framework.Drivers
{
    public abstract class WebDriverFactory
    {
        protected string RemoteAddress = Env.RemoteAddress;

        public abstract IWebDriver CreateLocal();

        public abstract IWebDriver CreateRemote();
    }
}