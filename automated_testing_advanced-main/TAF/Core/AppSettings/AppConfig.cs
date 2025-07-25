using System;
using Core.Enums;
using Microsoft.Extensions.Configuration;

namespace Core.AppSettings
{
    public static class AppConfig
    {
        public static int ExplicitTimeout => Convert.ToInt32(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("ApplicationConfig:ExplicitTimeout"));
        public static BrowserName BrowserName => Enum.Parse<BrowserName>(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("ApplicationConfig:Browser"));
        public static string URL => new string(TestConfigurationManager.GetConfigurationRoot().GetValue<string>("ApplicationConfig:URL"));
    }
}