﻿#if EXILED
using System;
using System.IO;
using CBXKomendyNarracyjne;
using Exiled.API.Features;

namespace RolePlay_Tools
{
    public class Plugin : Plugin<Config>
    {

        public static Plugin Instance;
        public EventHandlers eventHandlers { get; set; }
        public API API { get; set; }
        public const string PluginVersion = "1.3.0";
        public string HintsFilePath;

        public override string Name => "KomendyNarracyjne";
        public override string Author => "!CBX";
        public override Version Version => new Version(PluginVersion);
        public override Version RequiredExiledVersion => new Version(8, 8, 0);

        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers();
            API = new API();
            RueI.RueIMain.EnsureInit();

            RegisterEvents();

            try
            {
                string path = Path.Combine(Paths.Plugins, "RolePlay-Tools");
                string hintsFile = Path.Combine(path, "RolePlay-Tools-Players.txt");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                if (!File.Exists(hintsFile))
                    File.Create(hintsFile).Close();
                HintsFilePath = hintsFile;

            }catch(Exception err)
            {
                Log.Error(err);
            }

            base.OnEnabled();

            Log.Debug($"{Name} {Version} by {Author} loaded succesfully!");
        }

        public override void OnDisabled()
        {
            Instance = null;
            eventHandlers = null;

            UnregisterEvents();
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            Exiled.Events.Handlers.Server.RoundEnded += eventHandlers.OnRoundEnded;
            Exiled.Events.Handlers.Player.Verified += eventHandlers.OnVerified;
            Exiled.Events.Handlers.Player.Jumping += eventHandlers.OnJumping;
        }
        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Server.RoundEnded -= eventHandlers.OnRoundEnded;
            Exiled.Events.Handlers.Player.Verified -= eventHandlers.OnVerified;
            Exiled.Events.Handlers.Player.Jumping -= eventHandlers.OnJumping;

        }
    }
}
#endif