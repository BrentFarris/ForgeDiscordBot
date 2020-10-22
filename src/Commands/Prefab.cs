namespace ForgeDiscordBot.src.Commands
{
    public class Prefab : TextResponse
    {
        protected override string Description() => "Shows a solution to a import prefab problem with Forge";
        protected override string Match() => "!prefab";
        protected override string Response() =>
@"Upon importing the Forge networking package, multiple errors might occur saying a prefab has multiple transforms. This is due a corrupted prefab from a Unity upgrade.
You can clear all these errors out as they dont prevent the project from compiling, however #community-answers has a fix.";
    }
}
