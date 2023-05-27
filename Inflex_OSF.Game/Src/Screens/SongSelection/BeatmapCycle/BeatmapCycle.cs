using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.UserInterface;
using osuTK;

namespace Infex_OSF.Game.Screens.SongSelection.BeatmapCycle;

public sealed class BeatmapCycle : Container
{
    public BeatmapCycle()
    {
        this.RelativeSizeAxes = Axes.Both;
        this.Width = 0.25f;

        const float relativeSize = 0.95f;

        this.Children = new Drawable[]
        {
            new BasicTextBox
            {
                RelativeSizeAxes = Axes.Both,
                Height = 1 - relativeSize,
                Anchor = Anchor.TopCentre,
                Origin = Anchor.TopCentre,
            },
            new InflexScrollContainer
            {
                RelativeSizeAxes = Axes.Both,
                Height = relativeSize,
                Anchor = Anchor.BottomCentre,
                Origin = Anchor.BottomCentre,
                ScrollbarAnchor = Anchor.TopLeft,
                ClampExtension = 0,
                Child = new FillFlowContainer
                {
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y,
                    Direction = FillDirection.Vertical,
                    Spacing = new Vector2(10),
                    Children = new[]
                    {
                        new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(),
                        new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(),
                        new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(),
                        new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(), new BeatmapButton(),
                        new BeatmapButton(), new BeatmapButton(),
                    },
                },
            },
        };
    }
}