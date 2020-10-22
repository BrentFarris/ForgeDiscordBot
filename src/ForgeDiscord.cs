using Discord;
using Discord.WebSocket;
using ForgeDiscordBot.src.Commands;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForgeDiscordBot.src
{
    public class ForgeDiscord
    {
        private readonly DiscordSocketClient _client;
        private readonly List<ICommand> _commands = new List<ICommand>();

        public ForgeDiscord()
        {
            _client = new DiscordSocketClient();
            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.MessageReceived += MessageReceivedAsync;
            _client.Connected += ConnectedAsync;
            _client.Disconnected += DisconnectedAsync;

            var help = new Help();
            _commands.Add(new Bug());
            _commands.Add(new Code());
            _commands.Add(new Devs());
            _commands.Add(new Docs());
            _commands.Add(help);
            _commands.Add(new Prefab());
            _commands.Add(new Suggestion());
            _commands.Add(new Troubleshoot());
            help.SetCommands(_commands);
        }

        private Task DisconnectedAsync(Exception arg)
        {
            LogAsync(new LogMessage(LogSeverity.Info, "", "Connection lost"));
            return Task.CompletedTask;
        }

        private Task ConnectedAsync()
        {
            LogAsync(new LogMessage(LogSeverity.Info, "", "Connection established"));
            return Task.CompletedTask;
        }

        public async Task MainAsync()
        {
            await _client.LoginAsync(TokenType.Bot,
                Environment.GetEnvironmentVariable("FORGE_DISCORDBOT_TOKEN"));
            await _client.StartAsync();
            await Task.Delay(-1);
        }

        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }

        private Task ReadyAsync()
        {
            Console.WriteLine($"{_client.CurrentUser} is connected!");
            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {
            if (message.Author.Id != _client.CurrentUser.Id)
                foreach (var c in _commands)
                    if (c.IsMatch(message))
                        await c.Run(message);
        }
    }
}
