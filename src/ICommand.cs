using Discord.WebSocket;
using ForgeDiscordBot.src.Commands;
using System.Threading.Tasks;

namespace ForgeDiscordBot.src
{
    public interface ICommand
    {
        CommandHelp Help();
        bool IsMatch(SocketMessage message);
        Task Run(SocketMessage message);
    }
}
