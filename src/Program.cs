using ForgeDiscordBot.src;

namespace ForgeDiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            new ForgeDiscord().MainAsync().GetAwaiter().GetResult();
        }
    }
}
