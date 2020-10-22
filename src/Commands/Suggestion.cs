namespace ForgeDiscordBot.src.Commands
{
    public class Suggestion : TextResponse
    {
        protected override string Description() => "Shows how developers can create suggestions for the library";
        protected override string Match() => "!suggestion";
        protected override string Response() =>
@"To report a suggestion, add it as an issue on github. https://github.com/BeardedManStudios/ForgeNetworkingRemastered/issues and label it with 'enhancement'";
    }
}
