using System;
using System.Collections.Generic;
using System.Linq;
using Core.UI.WebDriverWrapper;
using OpenQA.Selenium;
using static Core.Log;

namespace Core.UI.ElementWrapper
{
    public class Element : IElement
    {
        protected IWebElement WebElement;
        protected By By;
        private readonly Browser browser;

        public Element(IWebElement element, By by)
        {
            WebElement = element;
            By = by;
        }

        public string Text => WebElement.Text;

        public bool Selected => WebElement.Selected;

        public bool Displayed => WebElement.Displayed;

        public void Clear()
        {
            WebElement.Clear();
        }

        public void Click()
        {
            Information("The element was clicked");
            WebElement.Click();
        }

        public IElement FindElement(By by)
        {
            try
            {
                var wait = browser.WebBrowserWait();
                var webElement = wait.Until(drv => drv.FindElement(by));

                return new Element(webElement, by);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IReadOnlyCollection<IElement> FindElements(By by)
        {
            try
            {
                var wait = browser.WebBrowserWait();
                wait.Until(drv => drv.FindElements(by).Count > 0);
                IReadOnlyCollection<IWebElement> webELements = WebElement.FindElements(by);
                List<IElement> elements = new List<IElement>();

                foreach (IWebElement element in webELements)
                {
                    elements.Add(new Element(element, by));
                }

                return elements.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void Submit()
        {
            WebElement.Submit();
        } 
        
        public void SendKeys(string text)
        {
            WebElement.SendKeys(text);
            Information($"Text '{text}' was entered");
        }
    }
}