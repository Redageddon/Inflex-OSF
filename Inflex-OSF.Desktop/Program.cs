using Game.Game;
using osu.Framework;
using osu.Framework.Platform;

namespace Game.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using GameHost host = Host.GetSuitableHost(@"Inflex");
            using osu.Framework.Game game = new InflexGame();
            host?.Run(game);
        }
    }
}