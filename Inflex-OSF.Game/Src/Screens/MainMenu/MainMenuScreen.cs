using System;
using Inflex_OSF.Screens.Editor;
using Inflex_OSF.Screens.Multiplayer;
using Inflex_OSF.Screens.Screens;
using Inflex_OSF.Screens.Settings;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK;

namespace Inflex_OSF.Screens.MainMenu
{
    public class MainMenuScreen : InflexScreen
    {
        private readonly MainMenuButtonPanel buttonPanel;

        public MainMenuScreen()
        {
            this.BackButtonEnabled = false;
            this.AddRangeInternal(
                new Drawable[]
                {
                    this.buttonPanel = new MainMenuButtonPanel(
                        () => this.Push(new SongSelectionScreen()),
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
                });
        }
    }
}