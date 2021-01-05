using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Infex_OSF.Game.Screens.Pointer
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