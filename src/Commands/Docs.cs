namespace ForgeDiscordBot.src.Commands
{
    public class Docs : TextResponse
    {
        protected override string Description() => "Shows where to find documentation for Forge";
        protected override string Match() => "!docs";
        protected override string Response() =>
@"The official documentation for Forge Remastered: https://github.com/BeardedManStudios/ForgeNetworkingRemastered/wiki
The official documentation for Forge Alloy: https://github.com/BeardedManStudios/ForgeNetworkingRemastered/wiki/Forge-Networking-Alloy
Also, please visit the #faq, #community-answers and the #network-resources channels for additional information.";
    }
}
