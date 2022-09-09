using BotUnunin.Data;
using BotUnunin.Data.Infrastructure;
using BotUnunin.Handlers;
using BotUnunin.Services;
using Discord;
using Discord.Addons.Hosting;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Victoria;

var builder = new HostBuilder()
    .ConfigureAppConfiguration(x =>
    {
        var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", false, true)
                    .Build();

        x.AddConfiguration(configuration);
    }).ConfigureLogging(x =>
    {
        x.AddConsole();
        x.SetMinimumLevel(LogLevel.Debug);
    }).ConfigureDiscordHost((context, config) =>
    {
        config.SocketConfig = new DiscordSocketConfig
        {
            LogLevel = LogSeverity.Debug,
            AlwaysDownloadUsers = true,
            MessageCacheSize = 500
        };
        config.Token = context.Configuration["Token"];
    }).UseCommandService((context, config) =>
    {
        config.CaseSensitiveCommands = false;
        config.LogLevel = LogSeverity.Debug;
        config.DefaultRunMode = RunMode.Async;
    }).ConfigureServices((context, services) =>
    {
        services.AddHostedService<CommandHandler>()
            .AddDbContext<UnuninContext>(opt =>
            opt.UseSqlServer(
            context.Configuration.GetConnectionString("UnuninCnn")).EnableSensitiveDataLogging());
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ILoveServices, LoveServices>();
        services.AddScoped<IImageOfUsServices, ImageOfUsServices>();
        services.AddScoped<LavaLinkAudio>();
        services.AddLavaNode(x => { x.SelfDeaf = false; });
    })
    .UseConsoleLifetime();

var host = builder.Build();
await host.RunAsync();