﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SystemInfo.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
               .ConfigureAppConfiguration((hostingContext, config) =>
               {
                   config.AddJsonFile("appsettings.json", optional: false);
                   config.AddEnvironmentVariables();
                   config.AddCommandLine(args);
               })
               .ConfigureLogging((hostingContext, logging) => {
                   logging.AddConsole();
                   logging.SetMinimumLevel(LogLevel.Debug);
               })

               .ConfigureServices(services =>
               {
                   services.AddHostedService<MemoryClient>();
                   services.AddHostedService<GreeterClient>();
               });
            await builder.Build().RunAsync();
            
        }
    }
}
