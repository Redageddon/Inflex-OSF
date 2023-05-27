using Infex_OSF.Game;
using osu.Framework;
using osu.Framework.Bindables;
using osu.Framework.Platform;

namespace Inflex_OSF.Desktop;

public static class Program
{
    public static void Main()
    {
        using GameHost host = Host.GetSuitableHost(@"Inflex");
        using Game game = new InflexGame();
        host?.Run(game);
    }
}