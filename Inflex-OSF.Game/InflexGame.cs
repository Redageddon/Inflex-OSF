using Inflex_OSF.Game.MainMenu;
using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Inflex_OSF.Game
{
    public class InflexGame : InflexGameBase
    {
        private readonly ScreenStack screenStack;

        public InflexGame()
        {
            this.screenStack = new ScreenStack { RelativeSizeAxes = Axes.Both };
            this.Child = this.screenStack;
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();

            this.screenStack.Push(new MainMenuScreen());
        }
    }
}