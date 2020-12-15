using Inflex_OSF.Game.Background;
using Inflex_OSF.Game.MainMenu;
using Inflex_OSF.Game.Pointer;
using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Inflex_OSF.Game
{
    public class InflexGame : InflexGameBase
    {
        private readonly ScreenStack mainScreenStack;
        private readonly ScreenStack overlayScreenStack;
        private readonly ScreenStack underlayScreenStack;

        public InflexGame() =>
            this.Children = new[]
            {
                this.underlayScreenStack = new ScreenStack { RelativeSizeAxes = Axes.Both },
                this.mainScreenStack = new ScreenStack { RelativeSizeAxes = Axes.Both },
                this.overlayScreenStack = new ScreenStack { RelativeSizeAxes = Axes.Both },
            };

        protected override void LoadComplete()
        {
            base.LoadComplete();

            this.underlayScreenStack.Push(new DefaultBackground());
            this.mainScreenStack.Push(new MainMenuScreen());
            this.overlayScreenStack.Push(new PointerScreen());
        }
    }
}