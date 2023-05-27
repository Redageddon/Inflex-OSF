using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK;
using osuTK.Graphics;

namespace Infex_OSF.Game.Screens.SongSelection;

public class InflexScrollContainer : ScrollContainer<Drawable>
{
    public InflexScrollContainer(Direction scrollDirection = Direction.Vertical)
        : base(scrollDirection) {}

    protected override ScrollbarContainer CreateScrollbar(Direction direction) => new BasicScrollbar(direction);

    private class BasicScrollbar : ScrollbarContainer
    {
        private const float DimSize = 5;

        public BasicScrollbar(Direction direction)
            : base(direction)
        {
            this.Child = new Box
            {
                RelativeSizeAxes = Axes.Both,
                Colour = Color4.Red,
            };
        }

        public override void ResizeTo(float val, int duration = 0, Easing easing = Easing.None)
        {
            Vector2 size = new(DimSize)
            {
                [(int)this.ScrollDirection] = val,
            };

            this.ResizeTo(size, duration, easing);
        }
    }
}