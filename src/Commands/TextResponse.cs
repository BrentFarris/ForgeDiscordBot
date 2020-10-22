using Discord.WebSocket;
using System.Threading.Tasks;

namespace ForgeDiscordBot.src.Commands
{
    public abstract class TextResponse : ICommand
    {
        protected abstract string Description();
        protected abstract string Response();
        protected abstract string Match();

        public CommandHelp Help() => new CommandHelp
        {
            Command = Match(),
            Description = Description()
        };

        public bool IsMatch(SocketMessage message)
            => message.Content.ToLower().Equals(Match().ToLower());

        public async Task Run(SocketMessage message)
        {
            await message.Channel.SendMessageAsync(Response());
        }
    }
}
