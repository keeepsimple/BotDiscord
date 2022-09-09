using BotUnunin.Handlers;
using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victoria;

namespace BotUnunin.Services
{
    public class DiscordService
    {
        private readonly DiscordSocketClient _client;
        private readonly CommandHandler _command;
        private readonly ServiceProvider _services;
        private readonly LavaNode _lavaNode;
        private readonly LavaLinkAudio _audioServices;
        private readonly GlobalData _globalData;

        public DiscordService(DiscordSocketClient client, CommandHandler command, ServiceProvider services, LavaNode lavaNode, LavaLinkAudio audioServices, GlobalData globalData)
        {
            _client = client;
            _command = command;
            _services = services;
            _lavaNode = lavaNode;
            _audioServices = audioServices;
            _globalData = globalData;

            SubscribeLavaLinkEvents();
            SubscribeDiscordEvents();
        }

        public async Task InitializeAsync()
        {
            InitializeGlobalDataAsync();

            await _client.LoginAsync(TokenType.Bot, GlobalData.Config.Token);
            await _client.StartAsync();


            await Task.Delay(-1);
        }

        private void InitializeGlobalDataAsync()
        {
            _globalData.Initialize();
        }

        private void SubscribeLavaLinkEvents()
        {
            _lavaNode.OnLog += LogAsync;
            _lavaNode.OnTrackEnded += _audioServices.TrackEnded;
        }

        private void SubscribeDiscordEvents()
        {
            _client.Ready += ReadyAsync;
            _client.Log += LogAsync;
        }

        private async Task ReadyAsync()
        {
            try
            {
                await _lavaNode.ConnectAsync();
                await _client.SetGameAsync(GlobalData.Config.GameStatus);
            }
            catch (Exception ex)
            {
                await LoggingService.LogInformationAsync(ex.Source, ex.Message);
            }
        }

        private async Task LogAsync(LogMessage logMessage)
        {
            await LoggingService.LogAsync(logMessage.Source, logMessage.Severity, logMessage.Message);
        }
    }
}
