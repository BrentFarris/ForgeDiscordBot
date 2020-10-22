using System.Collections.Generic;
using System.Text;

namespace ForgeDiscordBot.src.Commands
{
    public class Help : TextResponse
    {
        private List<ICommand> _commands;
        public void SetCommands(List<ICommand> allCommands) { _commands = allCommands; }
        protected override string Description() => "Shows what you are looking at right now";
        protected override string Match() => "!help";
        protected override string Response()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in _commands)
            {
                var h = c.Help();
                sb.AppendLine($"**{h.Command}** - {h.Description}");
            }
            return sb.ToString();
        }
    }
}
