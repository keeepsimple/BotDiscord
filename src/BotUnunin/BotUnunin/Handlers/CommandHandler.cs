using System.Reflection;
using Discord;
using Discord.Addons.Hosting;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Victoria;

namespace BotUnunin.Handlers
{
    public class CommandHandler : DiscordClientService
    {
        private readonly IServiceProvider _provider;
        private readonly CommandService _commandService;
        private readonly IConfiguration _config;

        public CommandHandler(DiscordSocketClient client,
            ILogger<DiscordClientService> logger,
            IServiceProvider provider,
            CommandService commandService,
            IConfiguration config) : base(client, logger)
        {
            _provider = provider;
            _commandService = commandService;
            _config = config;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Client.MessageReceived += OnMessageReceived;
            _commandService.CommandExecuted += OnCommandExecuted;
            await _commandService.AddModulesAsync(Assembly.GetEntryAssembly(), _provider);
        }

        private async Task OnCommandExecuted(Optional<CommandInfo> commandInfo, ICommandContext commandContext, IResult result)
        {
            if (result.IsSuccess)
            {
                return;
            }

            await commandContext.Channel.SendMessageAsync(result.ErrorReason);
        }

        private async Task OnMessageReceived(SocketMessage socketMessage)
        {
            if (!(socketMessage is SocketUserMessage message) || message.Author.IsBot 
                || message.Channel is IDMChannel || message.Channel is IPrivateChannel) return;
            if (message.Source != MessageSource.User) return;

            var context = new SocketCommandContext(Client, message);

            var argPos = 0;
            if (!message.HasStringPrefix(_config["Prefix"], ref argPos)
                && !message.HasMentionPrefix(Client.CurrentUser, ref argPos)) return;
            await _commandService.ExecuteAsync(context, argPos, _provider);
        }
    }
}
