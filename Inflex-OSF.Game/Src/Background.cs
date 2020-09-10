using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Textures;
using osuTK.Graphics;

namespace Game.Game
{
    /// <summary>
    ///     A background for a screen.
    /// </summary>
    public sealed class Background : Box
    {
        [BackgroundDependencyLoader]
        private void Load(TextureStore textures)
        {
            this.Colour = new Color4(30, 30, 30, 255);
            this.RelativeSizeAxes = Axes.Both;
        }
    }
}