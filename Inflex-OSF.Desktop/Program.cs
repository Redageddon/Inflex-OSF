using Game.Game;
using osu.Framework;
using osu.Framework.Platform;

namespace Game.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using GameHost host = Host.GetSuitableHost(@"Game");
            using osu.Framework.Game game = new GameGame();
            host?.Run(game);
        }
    }
}