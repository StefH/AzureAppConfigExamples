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
            Console.WriteLine(config["TestApp:Settings:Message"] ?? "Hello world!");
        }
    }
}