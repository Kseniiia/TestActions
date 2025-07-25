using Core.UI.ElementWrapper;
using Core.UI.WebDriverWrapper;
using PageObjects.Locators;

namespace PageObjects.Pages
{
    public class ReportPortalLoginPage : BasePage
    {
        public ReportPortalLoginPage(IBrowser driver) : base(driver)
        {
            this.Driver = driver;
        }
        
        public IElement LoginInput => Driver.FindElement(ReportPortalLoginPageBy.LoginInput);
        public IElement PasswordInput => Driver.FindElement(ReportPortalLoginPageBy.PasswordInput);
        public IElement LoginButton => Driver.FindElement(ReportPortalLoginPageBy.LoginButton);

        public ReportPortalDashboardsPage Login()
        {
            LoginInput.SendKeys("superadmin");
            PasswordInput.SendKeys("erebus");
            LoginButton.Click();
            return new ReportPortalDashboardsPage(Driver);
        }
    }
}