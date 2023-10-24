using Microsoft.EntityFrameworkCore;
using WebhookCamAi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("DbHRM"));
});


builder.Services.AddDbContext<FallbackDbContext>(option => {
    option.UseSqlite(builder.Configuration.GetConnectionString("Sqlite"));
});

builder.Services.AddScoped<IReceiveWebhook, ReceiveWebhook>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapPost("/webhook", async (HttpContext context, IReceiveWebhook receiveWebook) =>
{
    using StreamReader stream = new StreamReader(context.Request.Body);
    return await receiveWebook.Request(await stream.ReadToEndAsync());
});

app.Run();

