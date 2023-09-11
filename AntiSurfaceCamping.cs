using Exiled.API.Enums;
using Exiled.API.Features;
namespace AntiSurfaceCamping
{

    public class Plugin : Plugin<Config>
    {
        private static readonly Dictionary<Player, TimeSpan> PlayerSurfaceTimes = new Dictionary<Exiled.API.Features.Player, TimeSpan>();
        private static readonly TimeSpan UpdateInterval = TimeSpan.FromSeconds(1);


        public override string Name => "AntiSurfaceCamping";
        public override string Author => "Dashtiss";
        public override Version Version => new Version(1, 0, 3);
        public override void OnDisabled()
        {
            Log.Info("My AntiSurfaceCamping is disabled!");
        }
        public void OnUpdate()
        {
            // Update player surface times at the specified interval.
            foreach (Player player in Player.List)
            {
                if (player.Zone == ZoneType.Surface)
                {
                    if (!PlayerSurfaceTimes.ContainsKey(player))
                    {
                        PlayerSurfaceTimes[player] = TimeSpan.Zero;
                    }
                    PlayerSurfaceTimes[player] += UpdateInterval;
                    if (PlayerSurfaceTimes[player].TotalSeconds >= Config.MaxSurfaceTime)
                    {
                        // Apply damage to the player.
                        ApplyDamageToPlayer(player);
                    }
                }
            }
        }
        private void ApplyDamageToPlayer(Player player)
        {
            // You can customize the damage amount in your configuration.
            int damageAmount = Config.Damage;
            // Apply damage to the player.
            player.Hurt(damageAmount);
        }
    }
}
