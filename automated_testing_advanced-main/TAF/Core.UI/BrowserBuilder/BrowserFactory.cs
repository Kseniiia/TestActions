using Core.Enums;
using Core.UI.DriverFactory;
using Core.UI.WebDriverWrapper;
using OpenQA.Selenium;

namespace Core.UI.BrowserBuilder
{
    public class BrowserFactory
    {
        public static IBrowser Create(BrowserName browserName)
        {
            IWebDriver driver = WebDriverFactory.CreateWebDriver(browserName);

            return new Browser(driver);
        }
    }
}