using Microsoft.Extensions.Hosting.WindowsServices;

IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddHostedService<Worker>();
        });

if (WindowsServiceHelpers.IsWindowsService())
    hostBuilder.UseWindowsService();

IHost host = hostBuilder.Build();

await host.RunAsync();