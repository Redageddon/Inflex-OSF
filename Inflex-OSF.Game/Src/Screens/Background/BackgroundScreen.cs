using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Inflex_OSF.Screens.Background
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