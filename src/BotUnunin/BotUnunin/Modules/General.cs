using BotUnunin.Handlers;
using BotUnunin.Models;
using BotUnunin.Services;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace BotUnunin.Modules
{
    public class General : UnuninModuleBase
    {
        private readonly ILoveServices _loveServices;
        private readonly IImageOfUsServices _imageOfUsServices;

        public General(ILoveServices loveServices, IImageOfUsServices imageOfUsServices)
        {
            _loveServices = loveServices;
            _imageOfUsServices = imageOfUsServices;
        }

        [Command("ping")]
        public async Task PingAsync()
        {
            var embedRep = await EmbedHandler.CreateBasicEmbed("Ping", "Pongggggg");
            await ReplyAsync(embed: embedRep);
        }

        [Command("info")]
        public async Task InfoAsync(SocketGuildUser socketGuildUser = null)
        {
            if (socketGuildUser == null)
            {
                socketGuildUser = Context.User as SocketGuildUser;
            }

            var embed = new EmbedBuilder()
                .WithTitle($"{socketGuildUser.Username}#{socketGuildUser.Discriminator}")
                .AddField("ID", socketGuildUser.Id, true)
                .AddField("Name", $"{socketGuildUser.Username}#{socketGuildUser.Discriminator}", true)
                .AddField("Created At", socketGuildUser.CreatedAt.ToString("HH:mm:ss dd-MM-yyyy"), true)
                .WithColor(new Color(240, 168, 237))
                .WithThumbnailUrl(socketGuildUser.GetAvatarUrl() ?? socketGuildUser.GetDefaultAvatarUrl())
                .Build();

            await ReplyAsync(embed: embed);
        }

        [Command("firstdate")]
        [Alias("fd")]
        public async Task FirstDateAsync()
        {
            await Context.Channel.TriggerTypingAsync();
            var firstDate = await _loveServices.GetByIdAsync(1);
            var images = await _imageOfUsServices.GetImageByLoveId(firstDate.Id);
            string path = @"F:\Git Project\BotDiscord\src\BotUnunin\BotUnunin\Assets\";
            var listFile = new List<FileAttachment>();
            foreach (var item in images)
            {
                var attachment = new FileAttachment(path: path + item.Url, item.Url, item.Description);
                listFile.Add(attachment);
            }
            var embed = new EmbedBuilder().WithTitle(firstDate.Title).WithColor(new Color(240, 168, 237)).Build();
            await ReplyAsync(embed: embed);
            await Context.Channel.SendFilesAsync(listFile);
        }

        [Command("lovestart")]
        [Alias("lt")]
        public async Task LoveStartAsync()
        {
            await Context.Channel.TriggerTypingAsync();
            var loveStart = await _loveServices.GetByIdAsync(2);
            var images = await _imageOfUsServices.GetImageByLoveId(loveStart.Id);
            string path = @"F:\Git Project\BotDiscord\src\BotUnunin\BotUnunin\Assets\";
            var listFile = new List<FileAttachment>();
            foreach (var item in images)
            {
                var attachment = new FileAttachment(path: path + item.Url, item.Url, item.Description);
                listFile.Add(attachment);
            }
            var embed = new EmbedBuilder().WithTitle(loveStart.Title).WithColor(new Color(240, 168, 237)).Build();
            await ReplyAsync(embed: embed);
            await Context.Channel.SendFilesAsync(listFile);
        }

        [Command("oneMonth")]
        [Alias("om")]
        public async Task OneMonthAsync()
        {
            await Context.Channel.TriggerTypingAsync();
            var oneMonth = await _loveServices.GetByIdAsync(3);
            var images = await _imageOfUsServices.GetImageByLoveId(oneMonth.Id);
            var images1 = new List<ImageOfUs>();
            var images2 = new List<ImageOfUs>();
            if(images.Count() > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    images1.Add(images.ElementAt(i));
                }
                for (int i = 10; i < images.Count(); i++)
                {
                    images2.Add(images.ElementAt(i));
                }
            }
            string path = @"F:\Git Project\BotDiscord\src\BotUnunin\BotUnunin\Assets\";
            var listFile1 = new List<FileAttachment>();
            var listFile2 = new List<FileAttachment>();
            if(images.Count() > 10)
            {
                foreach (var item in images1)
                {
                    var attachment = new FileAttachment(path: path + item.Url, item.Url, item.Description);
                    listFile1.Add(attachment);
                }
                foreach (var item in images2)
                {
                    var attachment = new FileAttachment(path: path + item.Url, item.Url, item.Description);
                    listFile2.Add(attachment);
                }
                var embed = new EmbedBuilder().WithTitle(oneMonth.Title).WithColor(new Color(240, 168, 237)).Build();
                await ReplyAsync(embed: embed);
                await Context.Channel.SendFilesAsync(listFile1);
                await Context.Channel.SendFilesAsync(listFile2);
            }
            else
            {
                foreach (var item in images)
                {
                    var attachment = new FileAttachment(path: path + item.Url, item.Url, item.Description);
                    listFile1.Add(attachment);
                }
                var embed = new EmbedBuilder().WithTitle(oneMonth.Title).WithColor(new Color(240, 168, 237)).Build();
                await ReplyAsync(embed: embed);
                await Context.Channel.SendFilesAsync(listFile1);
            }
        }
    }
}
