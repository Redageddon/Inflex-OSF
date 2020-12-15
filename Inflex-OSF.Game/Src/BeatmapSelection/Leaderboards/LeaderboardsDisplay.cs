using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK;
using osuTK.Graphics;

namespace Inflex_OSF.Game.Screens
{
    public class LeaderboardsDisplay : Container
    {
        public IEnumerable<int> GlobalScores { get; }

        public IEnumerable<int> LocalScores { get; }

        public IEnumerable<int> FriendScores { get; }

        public LeaderboardsDisplay() =>
            this.Children = new Drawable[]
            {
                new Box
                {
                    Size = new Vector2(200, 200),
                },
                new Box
                {
                    RelativeSizeAxes = Axes.Both,
                    Colour = Colour4.White,
                },
                new SpriteText
                {
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Size = new Vector2(100, 30),
                    Colour = Color4.Black,
                    Text = "Leaderboards",
                },
                new BasicScrollContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    ScrollbarAnchor = Anchor.TopLeft,
                    ClampExtension = 0,
                    Child = new FillFlowContainer
                    {
                        RelativeSizeAxes = Axes.X,
                        AutoSizeAxes = Axes.Y,
                        Direction = FillDirection.Vertical,
                        Spacing = new Vector2(20),
                        Children = new[]
                        {
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Red,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                            new Box
                            {
                                Size = new Vector2(100, 100),
                                Colour = Colour4.Green,
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                            },
                        },
                    },
                },
            };
    }
}