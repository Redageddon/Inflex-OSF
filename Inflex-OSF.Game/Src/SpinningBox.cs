using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;

namespace Game.Game
{
    /// <summary>
    ///     A spinning box with a texture.
    /// </summary>
    public sealed class SpinningBox : CompositeDrawable
    {
        private Container box;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SpinningBox"/> class.
        /// </summary>
        public SpinningBox()
        {
            this.AutoSizeAxes = Axes.Both;
            this.Origin = Anchor.Centre;
        }

        /// <inheritdoc/>
        protected override void LoadComplete()
        {
            base.LoadComplete();
            this.box.Loop(b => b.RotateTo(0).RotateTo(360, 2500));
        }

        [BackgroundDependencyLoader]
        private void Load(TextureStore textures) =>
            this.InternalChild = this.box = new Container
            {
                AutoSizeAxes = Axes.Both,
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Children = new Drawable[]
                {
                    new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                    },
                    new Sprite
                    {
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                        Texture = textures.Get("logo"),
                    },
                },
            };
    }
}