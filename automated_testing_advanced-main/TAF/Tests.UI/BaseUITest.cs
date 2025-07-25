using Core.AppSettings;
using Core.UI.BrowserBuilder;
using Core.UI.WebDriverWrapper;
using NUnit.Framework;

namespace Tests.UI
{
    public class BaseUiTest
    {
        protected IBrowser Browser;
        
        [SetUp]
        public void Setup()
        {
            Browser = BrowserCreator.GetBrowser(AppConfig.BrowserName);
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl(AppConfig.URL);
        }
        
        [TearDown]
        public void TearDown()
        {
            BrowserCreator.ReleaseInstance();
            Browser.Close();
            Browser.Quit();
        }
    }
}