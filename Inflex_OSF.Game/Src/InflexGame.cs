using Infex_OSF.Game.Beatmaps;
using Infex_OSF.Game.Screens.Background;
using Infex_OSF.Game.Screens.MainMenu;
using Infex_OSF.Game.Screens.Pointer;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Screens;

namespace Infex_OSF.Game
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