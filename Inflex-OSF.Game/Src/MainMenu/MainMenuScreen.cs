using System;
using Inflex_OSF.Game.Editor;
using Inflex_OSF.Game.Multiplayer;
using Inflex_OSF.Game.Screens;
using Inflex_OSF.Game.Settings;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;

namespace Inflex_OSF.Game.MainMenu
{
    public class MainMenuScreen : Screen
    {
        public MainMenuScreen() =>
            this.InternalChildren = new Drawable[]
            {
                new MainMenuButtonPanel(
                    () => this.Push(new BeatmapSelectionScreen()),
                    () => this.Push(new MultiplayerScreen()),
                    () => this.Push(new SettingsScreen()),
                    () => this.Push(new EditorScreen()),
                    () => Environment.Exit(0))
                {
                    Anchor = Anchor.Centre,
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
    }
}