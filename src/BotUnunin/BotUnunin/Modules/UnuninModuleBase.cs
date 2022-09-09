using BotUnunin.Services;
using Discord;
using Discord.Commands;
using Discord.Rest;

namespace BotUnunin.Modules
{
    public abstract class UnuninModuleBase : ModuleBase<SocketCommandContext>
    {
        public async Task<RestUserMessage> SendEmbedAsync(string title, string description)
        {
            var builder = new EmbedBuilder()
                .WithTitle(title)
                .WithDescription(description);

            return await Context.Channel.SendMessageAsync(embed: builder.Build());
        }
    }
}
