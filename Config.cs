namespace AntiSurfaceCamping
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; }
        [Description("Debug.")]
        public bool Debug { get; set; }
        [Description("What is broadcasted to them if someone is on surface.")]
        public string BraoadcastText { get; set; } = "You are slowly taking radiation poisoning";
        [Description("How Much damage players take on surface")]
        public int Damage { get; set; } = 5; // Set to 5 by default.
    }
}