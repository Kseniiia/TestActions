using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Core.Enums;

namespace Core.UI.DriverFactory
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(BrowserName browser)
            {
                IWebDriver driver;

                switch (browser)
                {
                    case BrowserName.Chrome:
                        var chromeOption = new ChromeOptions();
                        chromeOption.AddArgument("headless");
                        driver = new ChromeDriver(chromeOption);
                        break;
                    default:
                        throw new PlatformNotSupportedException($"{browser} is not currently supported.");
                }
                return driver;
            }
    }
}