namespace ForgeDiscordBot.src.Commands
{
    public class Bug : TextResponse
    {
        protected override string Description() => "Shows how to report a bug for Forge";
        protected override string Match() => "!bug";
        protected override string Response() =>
@"To report a bug, add it as an issue on github. https://github.com/BeardedManStudios/ForgeNetworkingRemastered/issues";
    }
}
