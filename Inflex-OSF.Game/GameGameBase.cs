using Game.Resources;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.IO.Stores;
using osuTK;

namespace Game.Game
{
    /// <inheritdoc />
    public class GameGameBase : osu.Framework.Game
    {
        // Ensure game and tests scale with window size and screen DPI.

        /// <summary>
        ///     Initializes a new instance of the <see cref="GameGameBase"/> class.
        /// </summary>
        protected GameGameBase() =>
            base.Content.Add(this.Content = new DrawSizePreservingFillContainer
            {
                // You may want to change TargetDrawSize to your "default" resolution, which will decide how things scale and position when using absolute coordinates.
                TargetDrawSize = new Vector2(1920, 1080),
            });
        /* Anything in this class is shared between the test browser and the game implementation.
           It allows for caching global dependencies that should be accessible to tests, or changing
           the screen scaling for all components including the test browser and framework overlays.*/

        /// <inheritdoc/>
        protected override Container<Drawable> Content { get; }

        [BackgroundDependencyLoader]
        private void Load() => this.Resources.AddStore(new DllResourceStore(typeof(GameResources).Assembly));
    }
}