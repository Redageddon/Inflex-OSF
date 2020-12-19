using Inflex_OSF.Game.Screens.PlayDisplay;
using osu.Framework.Graphics;

namespace Inflex_OSF.Game.Screens
{
    public class BeatmapSelectionScreen : InflexScreen
    {
        public BeatmapSelectionScreen() =>
            this.AddRangeInternal(
                new Drawable[]
                {
                    new LeaderboardsDisplay
                    {
                        Anchor = Anchor.TopLeft,
                        Origin = Anchor.TopLeft,
                    },
                    new BeatmapCycle
                    {
                        Anchor = Anchor.CentreRight,
                        Origin = Anchor.CentreRight,
                    },
                    new PLayDisplay
                    {
                        Anchor = Anchor.BottomCentre,
                        Origin = Anchor.BottomCentre,
                    },
                });
    }
}