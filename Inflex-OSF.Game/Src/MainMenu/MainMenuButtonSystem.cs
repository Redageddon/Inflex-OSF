using System;
using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK;
using osuTK.Graphics;

namespace Game.Game.MainMenu
{
    /// <inheritdoc />
    public class MainMenuButtonSystem : CompositeDrawable
    {
        public Action OnBeatmapSelector { get; set; }

        public Action OnEditor { get; set; }

        public Action OnMulti { get; set; }

        public Action OnQuit { get; set; }

        public Action OnSettings { get; set; }

        [BackgroundDependencyLoader]
        private void Load()
        {
            this.InternalChild = new Container
            {
                AutoSizeAxes = Axes.Both,
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Children = new Drawable[]
                {
                    new Box
                    {
                        Size = new Vector2(210, 510),
                        Position = new Vector2(-5, -5),
                    },
                    new VerticalFitter(50)
                    {
                        Size = new Vector2(200, 500),
                        Children = new Drawable[]
                        {
                            new MainMenuButton("Play", null, new Color4(0, 200, 0, 255)),
                            new MainMenuButton("Settings", null, new Color4(200, 0, 0, 255)),
                            new MainMenuButton("Editor", null, new Color4(0, 200, 0, 255)),
                            new MainMenuButton("Test", null, new Color4(200, 0, 0, 255)),
                            new MainMenuButton("Quit", null, new Color4(0, 200, 0, 255)),
                        },
                    },
                },
            };
        }
    }
}