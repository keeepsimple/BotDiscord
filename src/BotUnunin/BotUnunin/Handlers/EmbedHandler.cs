using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotUnunin.Handlers
{
    public static class EmbedHandler
    {
        public static async Task<Embed> CreateBasicEmbed(string title, string desc)
        {
            var embed = await Task.Run(() => new EmbedBuilder()
                                                    .WithTitle(title)
                                                    .WithDescription(desc)
                                                    .WithColor(new Color(240, 168, 237))
                                                    .WithCurrentTimestamp().Build());
            return embed;
        }

        public static async Task<Embed> CreateErrorEmbed(string source, string error)
        {
            var embed = await Task.Run(() => new EmbedBuilder()
                .WithTitle($"ERROR OCCURED FROM - {source}")
                .WithDescription($"**Error Deaitls**: \n{error}")
                .WithColor(Color.DarkRed)
                .WithCurrentTimestamp().Build());
            return embed;
        }
    }
}
