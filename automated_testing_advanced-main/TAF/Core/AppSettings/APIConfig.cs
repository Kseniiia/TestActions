using System;
using Microsoft.Extensions.Configuration;

namespace Core.AppSettings
{
    public class APIConfig
    {
        public int Timeout => Convert.ToInt32(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("APIConfig:Timeout"));
        public string URL => new string(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("APIConfig:URL"));

        public string Token = "322d186e-3c3c-4fee-81f3-185a637f503b";
    }
}