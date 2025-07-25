using Core.UI.WebDriverWrapper;

namespace PageObjects
{
    public class BasePage
    {
        protected IBrowser Driver;

        protected BasePage(IBrowser driver)
        {
            Driver = driver;
        }
    }
}