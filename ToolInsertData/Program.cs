using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using ToolInsertData.Handler;

namespace ToolInsertData
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //var config = new HttpSelfHostConfiguration("http://localhost:8080");
            //config.Routes.MapHttpRoute(
            //    "DefaultApi", "webhook", new { id = RouteParameter.Optional });
            //config.MessageHandlers.Add(new WebhookHandler());
            //using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            //{
            //    server.OpenAsync().Wait();

            //}
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            CreateWebHostBuilder(args).Build().RunAsync();
            ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
             WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>();
    }
}