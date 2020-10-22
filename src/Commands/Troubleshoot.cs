namespace ForgeDiscordBot.src.Commands
{
    public class Troubleshoot : TextResponse
    {
        protected override string Description() => "Shows information about troubleshooting the Forge Networking library";
        protected override string Match() => "!troubleshoot";
        protected override string Response() =>
@"Troubleshoot tips
1. If you are getting a null exception, make sure you are running the main menu first.
2. The NCW will appear blank if the project cannot compile. Make sure you implement a newly created RPC into your network object script right after creating it.
3. Make sure your Unity project has Run in Background turned on. See #faq for more information.
4. Report back which version of Forge you are using and which version of Unity you are using.";
    }
}
