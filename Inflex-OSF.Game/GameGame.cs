using Game.Game.MainMenu;
using Game.Game.Screens;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Game.Game
{
    /// <inheritdoc />
    public class GameGame : GameGameBase
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