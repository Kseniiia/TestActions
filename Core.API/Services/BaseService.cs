using Core.API.Managers;

namespace Core.API.Services
{
    public class BaseService
    {
        protected readonly ISessionManager SessionManager;

        public BaseService(ISessionManager sessionManager)
        {
            SessionManager = sessionManager;
        } 
    }
}