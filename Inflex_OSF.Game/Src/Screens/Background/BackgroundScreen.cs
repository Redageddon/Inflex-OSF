using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Infex_OSF.Game.Screens.Background;

public abstract class BackgroundScreen : Screen
{
    protected BackgroundScreen()
    {
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;
    }
}