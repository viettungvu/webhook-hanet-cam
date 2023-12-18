using Infra.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FormSendMail
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

            Application.Run(ServiceProvider.GetRequiredService<frmIncome>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<HRMDbContext>(options =>
                    {
                        options.UseSqlServer(context.Configuration.GetConnectionString("DbHRM"));
                    });
                    services.AddTransient<frmIncome>();
                });
        }
    }
}