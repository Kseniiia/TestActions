using System.Text.Json;
using Core.API.Managers;
using Models;

namespace Core.API.Services
{
    public class UserServiceHelper : BaseServiceHelper
    {
        private readonly UserService userService;

        public UserServiceHelper(ISessionManager sessionManager) : base(sessionManager)
        {
            userService = new UserService(sessionManager);
        }

        public UserData GetSingleUserInfo()
        {
            var response = userService.GetSingleUserInfo();

            return JsonSerializer.Deserialize<UserData>(response.Content); 
        }
    }
}