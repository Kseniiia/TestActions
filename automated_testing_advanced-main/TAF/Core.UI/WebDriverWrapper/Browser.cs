using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using Core.UI.ElementWrapper;
using Core.AppSettings;
using System.Collections.Generic;
using System.Linq;
using static Core.Log;

namespace Core.UI.WebDriverWrapper
{
    public class Browser : IBrowser
    {
        private IWebDriver webDriver;
        private int waitTimeInSeconds = AppConfig.ExplicitTimeout;
        
        public Browser(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public IElement FindElement(By by)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(waitTimeInSeconds));
                var webElement = wait.Until(drv => drv.FindElement(by));

                Information("The element {0} was found successfully", by);

                return new Element(webElement, by);
            }
            catch (Exception e)
            {
                Error("The element {0} was found", by);
                throw e;
            }
        }

        public IReadOnlyCollection<IElement> FindElements(By by)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(waitTimeInSeconds));
                wait.Until(drv => drv.FindElements(by).Count > 0);
                var webElements = webDriver.FindElements(by);
                var elements = new List<IElement>();

                foreach (IWebElement webElement in webElements)
                {
                    elements.Add(new Element(webElement, by));
                }
                return elements.ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string Url
        {
            get => webDriver.Url;
            set => webDriver.Url = value;
        }

        public WebDriverWait WebBrowserWait() => new WebDriverWait(webDriver, TimeSpan.FromSeconds(waitTimeInSeconds));

        public IOptions Manage()
        {
           return webDriver.Manage();            
        }

        public INavigation Navigate()
        {
            return webDriver.Navigate();
        }

        public void Quit()
        {
            webDriver.Quit();
        }

        public void Close()
        {
            webDriver.Close();
        }

        public void Dispose()
        {
            webDriver.Dispose();
        }
    }
}