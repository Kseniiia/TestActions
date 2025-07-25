using Core.AppSettings;
using RestSharp;
using RestSharp.Authenticators.OAuth2;

namespace Core.API.Managers
{
    public class SessionManager : ISessionManager
    {
        private readonly APIConfig apiConfig;
        public SessionManager(APIConfig apiConfig)
        {
            this.apiConfig = apiConfig;
        }
        public RestClient RestClient {
            get
            {
                var options = new RestClientOptions(apiConfig.URL)
                {
                    MaxTimeout = apiConfig.Timeout
                };
               
                return new RestClient(options)
                {
                    Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(apiConfig.Token, "Bearer")
                };
            }
        }

        public RestRequest RestRequest {
            get
            {
                var restRequest = new RestRequest 
                {
                    Timeout = apiConfig.Timeout
                };

                return restRequest;
            } 
        } 
    }
}