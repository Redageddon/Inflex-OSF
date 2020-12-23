using Inflex_OSF.Screens.Background;
using Inflex_OSF.Screens.MainMenu;
using Inflex_OSF.Screens.Pointer;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Inflex_OSF.Screens
{
    public class InflexGame : InflexGameBase
    {
        private readonly ScreenStack mainScreenStack;
        private readonly ScreenStack overlayScreenStack;
        private readonly ScreenStack underlayScreenStack;
        private DependencyContainer dependencies;

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

            this.dependencies.Cache(new BeatmapDatabase());
            this.underlayScreenStack.Push(new DefaultBackground());
            this.mainScreenStack.Push(new MainMenuScreen());
            this.overlayScreenStack.Push(new PointerScreen());
        }
    }
}