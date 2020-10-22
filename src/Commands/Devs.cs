namespace ForgeDiscordBot.src.Commands
{
    public class Devs : TextResponse
    {
        protected override string Description() => "Prints the original Forge Networking developer's discord names";
        protected override string Match() => "!devs";
        protected override string Response() =>
@"The developers of Forge networking are @Brent#6969 & @Brett#9519
The moderators of this discord server are just regular Forge users.";
    }
}
