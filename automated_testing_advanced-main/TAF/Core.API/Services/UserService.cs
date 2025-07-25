using Core.API.Managers;
using RestSharp;

namespace Core.API.Services
{
    public class UserService : BaseService
    {
        public UserService(ISessionManager sessionManager) : base(sessionManager)
        {
        }

        public RestResponse GetSingleUserInfo()
        {
            var client = SessionManager.RestClient;
            var request = SessionManager.RestRequest;

            request.Resource = $"/api/v1/user";
            request.Method = Method.Get;

            return client.Execute(request);
        }
    }
}