namespace ForgeDiscordBot.src.Commands
{
    public class Code : TextResponse
    {
        protected override string Description() => "Shows how to type code into discord so that there is syntax hilighting for C#";
        protected override string Match() => "!code";
        protected override string Response() =>
@"Here is an example of how to type C# code into Discord: https://imgur.com/by5zAC8";
    }
}
