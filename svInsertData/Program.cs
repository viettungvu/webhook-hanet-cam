using Microsoft.EntityFrameworkCore;
using System;
using svInsertData;
using svInsertData.Models;
using Serilog;

internal class Program
{
    static void CreateDbIfNoneExist(IHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            var service = scope.ServiceProvider;
            try
            {
                var context = service.GetRequiredService<SqliteDbContext>();
                context.Database.EnsureCreated();
            }
            catch (Exception)
            {
            }
        }
    }
    private static async Task Main(string[] args)
    {
        IHost host = Host.CreateDefaultBuilder(args)
            .UseWindowsService(opt =>
            {
                opt.ServiceName = ".NETServiceWebhook";
            })
            .UseSerilog((context, config) =>
            {
                string file = context.Configuration.GetValue<string>("LogFilePath");
                if (string.IsNullOrWhiteSpace(file))
                {
                    file = "C:\\svLogs\\log.txt";
                }
                config.WriteTo.File(file, Serilog.Events.LogEventLevel.Verbose);
            })
            .ConfigureServices((context, services) =>
            {
                IConfiguration configuration = context.Configuration;
                services.AddDbContext<SqliteDbContext>(opts =>
                {
                    opts.UseSqlite(configuration.GetConnectionString("Sqlite"));
                });
                services.AddDbContext<HRMDbContext>(opts =>
                {
                    opts.UseSqlServer(configuration.GetConnectionString("DbHRM"));
                });


                services.AddHostedService<HRMWorkerService>();
            })
            .Build();
        CreateDbIfNoneExist(host);
        await host.RunAsync();
    }
}