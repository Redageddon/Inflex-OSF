using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osuTK.Graphics;

namespace Inflex_OSF.Screens.Background
{
    public class DefaultBackground : BackgroundScreen
    {
        public DefaultBackground() =>
            this.InternalChild = new Box
            {
                Colour = new Color4(50, 50, 50, 255),
                RelativeSizeAxes = Axes.Both,
            };
    }
}