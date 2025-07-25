using Core.UI.ElementWrapper;
using Core.UI.WebDriverWrapper;
using PageObjects.Locators;

namespace PageObjects.Pages
{
    public class ReportPortalDashboardsPage : BasePage
    {
        public ReportPortalDashboardsPage(IBrowser driver) : base(driver)
        {
            this.Driver = driver;
        }
        
        public IElement LoginPopup => Driver.FindElement(ReportPortalDashboardsPageBy.LoginPopup);
    }
}