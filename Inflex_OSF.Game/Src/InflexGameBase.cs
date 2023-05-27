using Inflex_OSF.Resources;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.IO.Stores;
using osuTK;

namespace Infex_OSF.Game;

public class InflexGameBase : osu.Framework.Game
{
    protected InflexGameBase()
    {
        base.Content.Add(this.Content = new DrawSizePreservingFillContainer
        {
            TargetDrawSize = new Vector2(1920, 1080),
        });
    }

    protected override Container<Drawable> Content { get; }

    [BackgroundDependencyLoader]
    private void Load() => this.Resources.AddStore(new DllResourceStore(typeof(GameResources).Assembly));
}