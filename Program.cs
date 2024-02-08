using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using PdfEmailSender.Extensions.Configuration;
using PdfEmailSender.Models;


var host = CreateHostBuilder(args).Build();

var mySettings = host.Services.GetRequiredService<IOptions<AppSettings>>().Value;

Console.WriteLine($"Environment: {mySettings.Environment}");
Console.WriteLine($"Prop1: {mySettings.Message}");
Console.WriteLine($"Version: {mySettings.Version}");

await host.RunAsync();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureApp();