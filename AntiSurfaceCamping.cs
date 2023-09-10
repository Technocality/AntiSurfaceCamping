namespace AntiSurfaceCamping
{
    using System;

    using CommandSystem;

    using Exiled.API.Enums;
    using Exiled.API.Extensions;
    using Exiled.API.Features;
    using Exiled.CustomItems.API.Features;
    using Exiled.Events.Handlers;
    using Exiled.Permissions.Extensions;
    using PlayerRoles;
    using PluginAPI.Core;
    using Log = PluginAPI.Core.Log;

    public class Plugin : Plugin<Config>
    {
        
        public override string Name => "AntiSurfaceCamping";
        public override string Author => "Dashtiss";
        public override Version Version => new Version(1, 0, 1);
        public override void OnEnabled()
        {
            Log.Info("My plugin has been enabled!");
        }
        public override void OnDisabled()
        {
            Log.Info("My plugin has been disabled!");
        }
        private void SurfaceCheck()
        {
            if (PluginAPI.Core.Round.IsRoundStarted)
            {
                Log.Info('RoundStarted')
            }
        }
    }
}
