using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;

namespace Infex_OSF.Game
{
    public sealed class SpinningBox : CompositeDrawable
    {
        private readonly Container box;
        private readonly Sprite sprite;

        public SpinningBox()
        {
            this.AutoSizeAxes = Axes.Both;
            this.Origin = Anchor.Centre;

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
                    this.sprite = new Sprite
                    {
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                    },
                },
            };
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();
            this.box.Loop(b => b.RotateTo(0)?.RotateTo(360, 2500));
        }

        [BackgroundDependencyLoader]
        private void Load(TextureStore textures) => this.sprite.Texture = textures.Get("logo");
    }
}