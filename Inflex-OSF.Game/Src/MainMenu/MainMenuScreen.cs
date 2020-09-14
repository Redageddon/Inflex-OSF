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
    /// <inheritdoc />
    public class MainMenuScreen : Screen
    {
        public MainMenuScreen() =>
            this.InternalChildren = new Drawable[]
            {
                new MainMenuButtonPanel
                {
                    Anchor = Anchor.Centre,
                    OnPlay = () => this.Push(new BeatmapSelectionScreen()),
                    OnMultiplayer = () => this.Push(new MultiplayerScreen()),
                    OnSettings = () => this.Push(new SettingsScreen()),
                    OnEditor = () => this.Push(new EditorScreen()),
                    OnQuit = () => Environment.Exit(0),
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