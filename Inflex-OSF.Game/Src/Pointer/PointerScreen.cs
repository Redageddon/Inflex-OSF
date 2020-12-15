using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Inflex_OSF.Game.Pointer
{
    public class PointerScreen : Screen
    {
        public PointerScreen() =>
            this.InternalChild =
                new PointerSystem
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                };
    }
}