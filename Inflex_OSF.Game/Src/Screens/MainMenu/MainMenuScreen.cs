using System;
using Infex_OSF.Game.Screens.Editor;
using Infex_OSF.Game.Screens.Multiplayer;
using Infex_OSF.Game.Screens.Settings;
using Infex_OSF.Game.Screens.SongSelection;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK;

namespace Infex_OSF.Game.Screens.MainMenu;

public class MainMenuScreen : InflexScreen
{
    private readonly MainMenuButtonPanel buttonPanel;

    public MainMenuScreen()
    {
        this.BackButtonEnabled = false;

        this.AddRangeInternal(new Drawable[]
        {
            this.buttonPanel = new MainMenuButtonPanel(() => this.Push(new SongSelectionScreen()),
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