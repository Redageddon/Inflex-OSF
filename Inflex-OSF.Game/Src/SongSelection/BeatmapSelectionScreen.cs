using Inflex_OSF.Game.Screens.PlayDisplay;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK;

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
                    new DetailsDisplay
                    {
                        Anchor = Anchor.TopCentre,
                        Origin = Anchor.TopCentre,
                    },
                    new Container
                    {
                        Size = new Vector2(150),
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                        Children = new Drawable[]
                        {
                            new Circle
                            {
                                RelativeSizeAxes = Axes.Both,
                                Colour = Colour4.Red,
                            },
                            new SpriteText
                            {
                                Anchor = Anchor.Centre,
                                Origin = Anchor.Centre,
                                Text = "Play",
                            },
                        },
                    },
                });
    }
}