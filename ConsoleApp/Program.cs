using System;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddAzureAppConfiguration(Environment.GetEnvironmentVariable("AzureAppConfigConnectionString_StefHeyenrath"));

            var config = builder.Build();

            Console.WriteLine("TestApp:Settings:Message = '{0}", config["TestApp:Settings:Message"]);
            Console.WriteLine("MyFirstKeyVaultThing     = '{0}", config["MyFirstKeyVaultThing"]);
        }
    }
}