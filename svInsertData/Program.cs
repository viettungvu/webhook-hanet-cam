using Microsoft.EntityFrameworkCore;
using System;
using svInsertData;
using svInsertData.Models;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        IConfiguration configuration = context.Configuration;
        var optionsBuilder = new DbContextOptionsBuilder<FallbackDbContext>();

        optionsBuilder.UseSqlite(configuration.GetConnectionString("Sqlite"));
        services.AddScoped<FallbackDbContext>(db => new FallbackDbContext(optionsBuilder.Options));


        var optionsBoptuilder = new DbContextOptionsBuilder<FallbackDbContext>();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbHRM"));
        services.AddScoped<FallbackDbContext>(db => new FallbackDbContext(optionsBuilder.Options));

        services.AddHostedService<Worker>();
    })
    .Build();


CreateDbIfNoneExist(host);

await host.RunAsync();
void CreateDbIfNoneExist(IHost host)
{
    using (var scope = host.Services.CreateScope())
    {
        var service = scope.ServiceProvider;

        try
        {
            var context = service.GetRequiredService<FallbackDbContext>();
            context.Database.EnsureCreated();
        }
        catch (Exception)
        {
        }
    }
}