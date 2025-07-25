using Core.API.Services;
using NUnit.Framework;

namespace Tests.API
{
    public class GetMethodTest : BaseAPITest
    {
        [TestCase("superadminemail@domain.com")]
        public void CheckGetSingleUserInfo(string userEmail)
        {
            var userData = userServiceHelper.GetSingleUserInfo();

            userData.Email.Contains(userEmail);
        }
    }
}