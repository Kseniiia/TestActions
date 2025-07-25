using System.Collections.Generic;
using OpenQA.Selenium;

namespace Core.UI.ElementWrapper
{
    public interface IElement
    {
        string Text { get; }

        bool Selected { get; }

        bool Displayed { get; }
 
        void Clear();
        
        void Click();

        void Submit();

        IElement FindElement(By by);

        IReadOnlyCollection<IElement> FindElements(By by);
        
        void SendKeys(string text);
    }
}