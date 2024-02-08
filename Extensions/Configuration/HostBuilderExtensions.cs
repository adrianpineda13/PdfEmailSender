using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PdfEmailSender.Models;

namespace PdfEmailSender.Extensions.Configuration
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder ConfigureApp(this IHostBuilder hostBuilder)
        {
            return hostBuilder
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                          .AddEnvironmentConfiguration();
                })
            .ConfigureServices((hostContext, services) =>
            {
                services.Configure<AppSettings>(hostContext.Configuration);
            });
        }
    }
}