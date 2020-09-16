using Inflex_OSF.Resources;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.IO.Stores;
using osuTK;

namespace Inflex_OSF.Game
{
    public class InflexGameBase : osu.Framework.Game
    {
        protected InflexGameBase() =>
            base.Content.Add(
                this.Content = new DrawSizePreservingFillContainer
                {
                    TargetDrawSize = new Vector2(1920, 1080),
                });
        /* Anything in this class is shared between the test browser and the game implementation.
           It allows for caching global dependencies that should be accessible to tests, or changing
           the screen scaling for all components including the test browser and framework overlays.*/

        protected override Container<Drawable> Content { get; }

        [BackgroundDependencyLoader]
        private void Load() => this.Resources.AddStore(new DllResourceStore(typeof(GameResources).Assembly));
    }
}