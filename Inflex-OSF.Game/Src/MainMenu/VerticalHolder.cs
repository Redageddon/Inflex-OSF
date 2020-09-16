using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;

namespace Inflex_OSF.Game.MainMenu
{
    public sealed class VerticalHolder : Container
    {
        private readonly FillFlowContainer flow;

        public VerticalHolder(float spacing = 0) =>
            this.InternalChild = this.flow = new FillFlowContainer
            {
                Origin = Anchor.Centre,
                Spacing = new Vector2(0, spacing),
                Direction = FillDirection.Vertical,
                AutoSizeAxes = Axes.Both,
            };

        protected override Container<Drawable> Content => this.flow;
    }
}