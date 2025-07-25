using System;
using System.Collections.Generic;
using Core.UI.ElementWrapper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.UI.WebDriverWrapper
{
    public interface IBrowser : IDisposable
        {
            IElement FindElement(By by);
        
            IReadOnlyCollection<IElement> FindElements(By by);
            string Url { get; set; }

            WebDriverWait WebBrowserWait();
        
            IOptions Manage();

            INavigation Navigate();

            void Quit();

            void Close();
        }
}