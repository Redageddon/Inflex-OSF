using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK;
using osuTK.Graphics;

namespace Inflex_OSF.Game.Screens.PlayDisplay
{
    public sealed class DetailsDisplay : Container
    {
        public DetailsDisplay()
        {
            this.RelativeSizeAxes = Axes.X;
            this.Height = 100;
            this.Width = 0.5f;
            FontUsage defaultFont = FontUsage.Default.With(size: 30);
            Anchor defaultAnchor = Anchor.TopCentre;

            this.Children = new Drawable[]
            {
                new Box
                {
                    RelativeSizeAxes = Axes.Both,
                    Colour = new Colour4(40, 40, 40, 255),
                },
                new FillFlowContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    Spacing = new Vector2(20, 0),
                    Position = new Vector2(0, 20),
                    Children = new Drawable[]
                    {
                        new SpriteText
                        {
                            Anchor = defaultAnchor,
                            Origin = defaultAnchor,
                            Text = "Hit Object Count",
                            Font = defaultFont,
                        },
                        new SpriteText
                        {
                            Anchor = defaultAnchor,
                            Origin = defaultAnchor,
                            Text = "Song Length",
                            Font = defaultFont,
                        },
                        new SpriteText
                        {
                            Anchor = defaultAnchor,
                            Origin = defaultAnchor,
                            Text = "Difficulty",
                            Font = defaultFont,
                        },
                        new SpriteText
                        {
                            Anchor = defaultAnchor,
                            Origin = defaultAnchor,
                            Text = "Key Count",
                            Font = defaultFont,
                        },
                        new SpriteText
                        {
                            Anchor = defaultAnchor,
                            Origin = defaultAnchor,
                            Text = "Bpm",
                            Font = defaultFont,
                        },
                        new SpriteText
                        {
                            Anchor = defaultAnchor,
                            Origin = defaultAnchor,
                            Text = "Average Nps",
                            Font = defaultFont,
                        },
                        new SpriteText
                        {
                            Anchor = defaultAnchor,
                            Origin = defaultAnchor,
                            Text = "Drain rate",
                            Font = defaultFont,
                        },
                    },
                },
            };
        }
    }
}