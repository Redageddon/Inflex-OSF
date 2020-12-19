using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK;
using osuTK.Graphics;

namespace Inflex_OSF.Game.Screens.PlayDisplay
{
    public sealed class PLayDisplay : Container
    {
        public PLayDisplay()
        {
            this.Children = new Drawable[]
            {
                new Container
                {
                    Anchor = Anchor.BottomCentre,
                    Origin = Anchor.BottomCentre,
                    Size = new Vector2(100, 100),
                    Position = new Vector2(-100, -100),
                    Children = new Drawable[]
                    {
                        new Box
                        {
                            RelativeSizeAxes = Axes.Both,
                            Colour = Color4.Purple,
                        },
                        new SpriteText
                        {
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Play",
                        },
                    },
                },
                new Container
                {
                    Anchor = Anchor.BottomCentre,
                    Origin = Anchor.BottomCentre,
                    Size = new Vector2(100, 100),
                    Position = new Vector2(100, -100),
                    Children = new Drawable[]
                    {
                        new Box
                        {
                            RelativeSizeAxes = Axes.Both,
                            Colour = Color4.Blue,
                        },
                        new SpriteText
                        {
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Practice",
                        },
                    },
                },
                new Container
                {
                    Anchor = Anchor.BottomCentre,
                    Origin = Anchor.BottomCentre,
                    Size = new Vector2(300, 100),
                    Position = new Vector2(0, -200),
                    Children = new Drawable[]
                    {
                        new Box
                        {
                            RelativeSizeAxes = Axes.Both,
                            Colour = Color4.Blue,
                        },
                        new SpriteText
                        {
                            Position = new Vector2(),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Hit Object Count",
                        },
                        new SpriteText
                        {
                            Position = new Vector2(),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Song Length",
                        },
                        new SpriteText
                        {
                            Position = new Vector2(),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Difficulty",
                        },
                        new SpriteText
                        {
                            Position = new Vector2(),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Key Count",
                        },
                        new SpriteText
                        {
                            Position = new Vector2(),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Bpm",
                        },
                        new SpriteText
                        {
                            Position = new Vector2(),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Average Nps",
                        },
                        new SpriteText
                        {
                            Position = new Vector2(),
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Text = "Drain rate",
                        },
                    },
                },
            };
        }
    }
}