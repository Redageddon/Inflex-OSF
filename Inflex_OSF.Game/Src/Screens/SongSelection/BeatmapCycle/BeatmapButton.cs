using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK;

namespace Infex_OSF.Game.Screens.SongSelection.BeatmapCycle;

public sealed class BeatmapButton : Container
{
    public BeatmapButton()
    {
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;
        this.Size = new Vector2(500, 80);

        this.Children = new Drawable[]
        {
            new Box
            {
                Colour = new Colour4(20, 20, 20, 255),
                RelativeSizeAxes = Axes.Both,
            },
            new SpriteText
            {
                Position = new Vector2(-10, 0),
                Anchor = Anchor.CentreRight,
                Origin = Anchor.CentreRight,
                Text = "00.0",
                Font = FontUsage.Default.With(size: 50),
            },
            new SpriteText
            {
                Position = new Vector2(15, 0),
                Anchor = Anchor.TopLeft,
                Origin = Anchor.TopLeft,
                Text = "Title",
                AllowMultiline = false,
                Truncate = true,
                Width = 350,
                Font = FontUsage.Default.With(size: 50),
            },
            new SpriteText
            {
                Position = new Vector2(15, -5),
                Anchor = Anchor.BottomLeft,
                Origin = Anchor.BottomLeft,
                Text = "Author",
                AllowMultiline = false,
                Truncate = true,
                Width = 200,
                Font = FontUsage.Default.With(size: 30),
            },
            new SpriteText
            {
                Position = new Vector2(215, -5),
                Anchor = Anchor.BottomLeft,
                Origin = Anchor.BottomLeft,
                Text = "Creator",
                AllowMultiline = false,
                Truncate = true,
                Width = 200,
                Font = FontUsage.Default.With(size: 30),
            },
        };
    }
}