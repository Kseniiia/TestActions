using System;
using Serilog;

namespace Core
{
    public abstract class BaseTest
    {
        static BaseTest()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt")
                .CreateLogger();
        }     
    }
}