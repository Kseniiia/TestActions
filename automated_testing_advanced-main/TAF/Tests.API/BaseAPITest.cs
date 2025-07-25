using Core.API.Managers;
using Core.API.Services;
using Core.AppSettings;
using NUnit.Framework;

namespace Tests.API
{
    public class BaseAPITest
    {
        protected ISessionManager sessionManager;
        protected UserServiceHelper userServiceHelper;
       
        protected BaseAPITest()
        {
            APIConfig apiConfig = new APIConfig();
            sessionManager = new SessionManager(apiConfig);
            userServiceHelper = new UserServiceHelper(sessionManager);
        }
    }
}