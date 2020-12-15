using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Inflex_OSF.Game.Background
{
    public abstract class BackgroundScreen : Screen
    {
        protected BackgroundScreen()
        {
            this.Anchor = Anchor.Centre;
            this.Origin = Anchor.Centre;
        }
    }
}