using Microsoft.Extensions.Configuration;

namespace PdfEmailSender.Extensions.Configuration
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddEnvironmentConfiguration(this IConfigurationBuilder builder)
        {
            var environment = builder.Build()["Environment"] ?? "Development";
            var specificEnvironmentConfigFile = $"appsettings.{environment}.json";

            if (File.Exists(specificEnvironmentConfigFile))
            {
                builder.AddJsonFile(specificEnvironmentConfigFile, optional: true, reloadOnChange: true);
            }

            return builder;
        }
    }
}