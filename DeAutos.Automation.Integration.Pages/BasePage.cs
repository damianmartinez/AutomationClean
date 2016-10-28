using OpenQA.Selenium;

namespace DeAutos.Automation.Integration.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}