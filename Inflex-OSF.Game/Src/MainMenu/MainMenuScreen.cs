using System;
using Inflex_OSF.Game.Editor;
using Inflex_OSF.Game.Multiplayer;
using Inflex_OSF.Game.Screens;
using Inflex_OSF.Game.Settings;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK;

namespace Inflex_OSF.Game.MainMenu
{
    public class MainMenuScreen : Screen
    {
        private readonly MainMenuButtonPanel buttonPanel;

        public MainMenuScreen() =>
            this.InternalChildren = new Drawable[]
            {
                this.buttonPanel = new MainMenuButtonPanel(
                    () => this.Push(new BeatmapSelectionScreen()),
                    () => this.Push(new MultiplayerScreen()),
                    () => this.Push(new SettingsScreen()),
                    () => this.Push(new EditorScreen()),
                    () => Environment.Exit(0))
                {
                    Anchor = Anchor.CentreLeft,
                    Position = new Vector2(200, 0),
                },
                new SpriteText
                {
                    Y = 20,
                    Text = "Main Screen",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 40),
                },
            };

        public override void OnSuspending(IScreen next)
        {
            this.FadeOut(200, Easing.InQuint);
            this.buttonPanel.FlowToPosition(false);
            base.OnSuspending(next);
        }

        public override void OnResuming(IScreen last)
        {
            this.FadeIn(100, Easing.OutQuint);
            this.buttonPanel.FlowToPosition(true);
            base.OnResuming(last);
        }

        public override void OnEntering(IScreen last)
        {
            this.buttonPanel.FlowToPosition(true);
            base.OnEntering(last);
        }
    }
}