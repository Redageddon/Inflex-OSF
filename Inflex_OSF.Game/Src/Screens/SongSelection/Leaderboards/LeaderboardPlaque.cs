using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;

namespace Infex_OSF.Game.Screens.SongSelection.Leaderboards
{
    public sealed class LeaderboardPlaque : Container
    {
        public LeaderboardPlaque()
        {
            this.RelativeSizeAxes = Axes.X;
            this.Anchor = Anchor.Centre;
            this.Origin = Anchor.Centre;
            this.Height = 70;
            const float textSize = 50;

            const float xPosition = 160;

            this.Children = new Drawable[]
            {
                new Box
                {
                    Colour = new Colour4(20, 20, 20, 255),
                    RelativeSizeAxes = Axes.Both,
                },
                new SpriteText
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    X = -xPosition,
                    Text = this.HighScore.ToString(),
                    Font = FontUsage.Default.With(size: textSize),
                },
                new SpriteText
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Text = this.MaxCombo.ToString(),
                    Font = FontUsage.Default.With(size: textSize),
                },
                new SpriteText
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    X = xPosition,
                    Text = this.Accuracy.ToString(),
                    Font = FontUsage.Default.With(size: textSize),
                },
            };
        }

        public LeaderboardPlaque(int highScore, int maxCombo, float accuracy)
            : this()
        {
            this.HighScore = highScore;
            this.MaxCombo = maxCombo;
            this.Accuracy = accuracy;
        }

        public int HighScore { get; }

        public int MaxCombo { get; }

        public float Accuracy { get; }
    }
}