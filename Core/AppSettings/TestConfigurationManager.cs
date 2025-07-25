using System;
using Microsoft.Extensions.Configuration;

namespace Core.AppSettings
{
    public class TestConfigurationManager
    {
        public static IConfigurationRoot GetConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}