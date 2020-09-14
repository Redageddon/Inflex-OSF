using Inflex_OSF.Game.MainMenu;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Inflex_OSF.Game
{
    /// <inheritdoc />
    public class InflexGame : InflexGameBase
    {
        private ScreenStack screenStack;

        /// <inheritdoc />
        protected override void LoadComplete()
        {
            base.LoadComplete();

            this.screenStack.Push(new MainMenuScreen());
        }

        [BackgroundDependencyLoader]
        private void Load()
        {
            this.screenStack = new ScreenStack { RelativeSizeAxes = Axes.Both };
            this.Child = this.screenStack;
        }
    }
}