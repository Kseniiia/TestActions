using FluentAssertions;
using NUnit.Framework;
using PageObjects.Pages;

namespace Tests.UI
{
    [TestFixture]
    
    public class ReportPortalLoginPageTest : BaseUiTest
    {
        [Test]

        public void CheckReportPortalLoginPageToBeOpened()
        {
            ReportPortalLoginPage reportPortalLoginPage = new ReportPortalLoginPage(Browser);

            reportPortalLoginPage.LoginInput.Displayed.Should().BeTrue();
        }

        [Test]
        public void CheckReportPortalLoginToBeSuccessful()
        {
            ReportPortalLoginPage reportPortalLoginPage = new ReportPortalLoginPage(Browser);

            reportPortalLoginPage.Login().LoginPopup.Displayed.Should().BeTrue();
        }
    }
}