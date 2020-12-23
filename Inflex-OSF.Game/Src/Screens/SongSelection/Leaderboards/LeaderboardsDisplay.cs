using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK;
using osuTK.Graphics;

namespace Inflex_OSF.Screens.Screens
{
    public sealed class LeaderboardsDisplay : Container
    {
        public LeaderboardsDisplay()
        {
            this.RelativeSizeAxes = Axes.Both;
            this.Width = 0.25f;

            const float textSize = 90;
            const Anchor baseAnchor = Anchor.TopCentre;

            const float xPosition = 160;
            const float ySeparation = 0;

            this.Children = new Drawable[]
            {
                new Container
                {
                    Anchor = baseAnchor,
                    Origin = baseAnchor,
                    RelativeSizeAxes = Axes.X,
                    Height = textSize,
                    Children = new Drawable[]
                    {
                        new Box
                        {
                            RelativeSizeAxes = Axes.Both,
                            Colour = new Colour4(90, 90, 90, 255),
                        },
                        new SpriteText
                        {
                            Anchor = Anchor.Centre,
                            Origin = Anchor.Centre,
                            Colour = Color4.Black,
                            Text = "Leaderboards",
                            Font = FontUsage.Default.With(size: 60),
                        },
                        new SpriteText
                        {
                            Anchor = Anchor.BottomCentre,
                            Origin = Anchor.BottomCentre,
                            Position = new Vector2(-xPosition, -ySeparation),
                            Text = "HighScore",
                            Font = FontUsage.Default.With(size: 25),
                        },
                        new SpriteText
                        {
                            Anchor = Anchor.BottomCentre,
                            Origin = Anchor.BottomCentre,
                            Y = -ySeparation,
                            Text = "MaxCombo",
                            Font = FontUsage.Default.With(size: 25),
                        },
                        new SpriteText
                        {
                            Anchor = Anchor.BottomCentre,
                            Origin = Anchor.BottomCentre,
                            Position = new Vector2(xPosition, -ySeparation),
                            Text = "Accuracy",
                            Font = FontUsage.Default.With(size: 25),
                        },
                    },
                },
                new InflexScrollContainer
                {
                    RelativeSizeAxes = Axes.X,
                    Height = 1080 - (textSize + 500),
                    Position = new Vector2(0, textSize),
                    Anchor = baseAnchor,
                    Origin = baseAnchor,
                    ScrollbarAnchor = Anchor.TopRight,
                    ClampExtension = 0,
                    Child = new FillFlowContainer
                    {
                        RelativeSizeAxes = Axes.X,
                        AutoSizeAxes = Axes.Y,
                        Direction = FillDirection.Vertical,
                        Spacing = new Vector2(10),
                        Children = new[]
                        {
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                            new LeaderboardPlaque(),
                        },
                    },
                },
            };
        }

        public IEnumerable<LeaderboardPlaque>? LocalScores { get; }
    }
}