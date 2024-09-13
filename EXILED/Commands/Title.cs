#if EXILED
using System;
using System.ComponentModel;
using System.Linq;
using CommandSystem;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace RolePlay_Tools.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Title : ICommand
    {
        public string Command => "opis";

        public string[] Aliases => new string[] { "opis", "description", "desc" };

        public string Description => "Allows players to give their character a title or role, expressing their character's position or status in the fictional world.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!Plugin.Instance.Config.TitleCommand.IsEnabled)
            {
                response = "Komenda Została wyłączona przez Ownera!";
                return false;
            }

            if (Round.IsLobby)
            {
                response = "Nie możesz Używać Pluginu W Lobby!";
                return false;
            }

            Player player = Player.Get(sender);

            if (player == null)
            {
                response = "Error!";
                return false;
            }

            if (player.Role is not FpcRole)
            {
                response = "Niemożesz Używać Pluginu Jako SCP 079 Lub Obserwator!";
                return false;
            }
            if (arguments.Count == 0)
            {
                response = $"Use: .opis [text]";
                return false;
            }

            string text = string.Join(" ", arguments.Select(arg => arg.Trim()));

            if (Plugin.Instance.Config.DoCommand.MaxLenght > 0 && text.Length > Plugin.Instance.Config.TitleCommand.MaxLenght)
            {
                response = $"Twoj OPIS JEST ZA DŁUGI! Możesz Użyć Max: {Plugin.Instance.Config.TitleCommand.MaxLenght}";
                return false;
            }

            player.CustomInfo = string.Empty;
            player.CustomInfo = text;
            response = $"Ustawiono Opis!";
            return true;
        }
    }
}
#endif