using System;
using Azure.Identity;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = Environment.GetEnvironmentVariable("AzureAppConfigConnectionString_StefHeyenrath");

            IConfigurationBuilder configBuilder = new ConfigurationBuilder();
            IConfiguration config = configBuilder.AddAzureAppConfiguration(options => {
                
                // options.Connect(new Uri("https://***.azconfig.io"), new DefaultAzureCredential());

                options.Connect(connectionString);

                options.ConfigureKeyVault(kv => { kv.SetCredential(new DefaultAzureCredential(true)); });
            }).Build();

            // var config = builder.Build();

            Console.WriteLine("TestApp:Settings:Message = '{0}", config["TestApp:Settings:Message"]);
            Console.WriteLine("MyFirstKeyVaultThing     = '{0}", config["MyFirstKeyVaultThing"]);
        }
    }
}