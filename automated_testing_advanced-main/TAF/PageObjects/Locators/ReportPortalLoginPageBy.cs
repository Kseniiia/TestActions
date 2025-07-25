using OpenQA.Selenium;

namespace PageObjects.Locators
{
    public class ReportPortalLoginPageBy
    {
        public static By LoginInput = By.XPath("//input[@type='text']");
        public static By PasswordInput = By.XPath("//input[@type='password']");
        public static By LoginButton = By.XPath("//button[@type='submit']");
    }
}