using System;
using Microsoft.Extensions.Configuration;

namespace TherapyBrandsAutomation.Config
{
    public class ConfigHandler
    {
        public ConfigHandler()
        {
        }

        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            string fileName = $"appsettings.{Environment.GetEnvironmentVariable("ENVIRONMENT")}.json";


            return new ConfigurationBuilder()

                .SetBasePath(outputPath)
                .AddJsonFile(fileName, optional: true)
                .Build();
        }

        public static T GetApplicationConfiguration<T>(string outputPath, string section) 
        {
            var configuration = (T)Activator.CreateInstance(typeof(T), new object[] { });

            var iConfig = GetIConfigurationRoot(outputPath);

            iConfig
                .GetSection(section)
                .Bind(configuration);

            return configuration;
        }
    }
}
