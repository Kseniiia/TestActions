using RestSharp;

namespace Core.API.Managers
{
    public interface ISessionManager
    {
        public RestRequest RestRequest { get; }

        public RestClient RestClient { get; } 
    }
}