using Infra.EF;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToolInsertCheckin.Core;

namespace ToolInsertCheckin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<frmAutoInsert>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<WebcamDbContext>(options =>
                    {
                        options.UseSqlServer(context.Configuration.GetConnectionString("DbWebcam"));
                    });
                    services.AddDbContext<HRMDbContext>(options =>
                    {
                        options.UseSqlServer(context.Configuration.GetConnectionString("DbHRM"));
                    });
                    services.AddScoped<AppDbContext>();
                    services.AddTransient<frmAutoInsert>();
                });
        }
    }
}