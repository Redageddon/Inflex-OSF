using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osuTK;

namespace Inflex_OSF.Game.Screens
{
    public class BeatmapSelectionScreen : InflexScreen
    {
        public BeatmapSelectionScreen() =>
            this.InternalChildren = new Drawable[]
            {
                new SpriteText
                {
                    Y = 20,
                    Text = "Beatmap Selection",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 40),
                },
                new LeaderboardsDisplay
                {
                    Anchor = Anchor.CentreRight,
                    Origin = Anchor.CentreRight,
                    RelativeSizeAxes = Axes.Y,
                    Size = new Vector2(500, 1),
                },
            };
    }
}