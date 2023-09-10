namespace AntiSurfaceCamping
{
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using System;
    public class Plugin : Plugin<Config>
    {
        public override string Name => "AntiSurfaceCamping";
        public override string Author => "Dashtiss";
        public override Version Version => new Version(1, 0, 0);
        public override void OnEnabled()
        {
            Log.Info("My plugin has been enabled!");
        }
        public override void OnDisabled()
        {
            Log.Info("My plugin has been disabled!");
        }
    }
}