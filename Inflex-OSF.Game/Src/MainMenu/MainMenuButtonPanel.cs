using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK;
using osuTK.Graphics;

namespace Inflex_OSF.Game.MainMenu
{
    public class MainMenuButtonPanel : Container
    {
        private readonly Vector2 buttonSize = new Vector2(200, 100);

        public MainMenuButtonPanel()
        {
            this.Child = new VerticalHolder
            {
                Children = new Drawable[]
                {
                    new MainMenuButton("Play", Colour4.Red, this.OnPlay, this.buttonSize),
                    new MainMenuButton("Multiplayer", Colour4.Orange, this.OnMultiplayer, this.buttonSize),
                    new MainMenuButton("Settings", Colour4.Yellow, this.OnSettings, this.buttonSize),
                    new MainMenuButton("Editor", Colour4.Green, this.OnEditor, this.buttonSize),
                    new MainMenuButton("Quit", Colour4.Blue, this.OnQuit, this.buttonSize),
                },
            };
        }

        public Action? OnPlay { get; set; }

        public Action? OnMultiplayer { get; set; }

        public Action? OnSettings { get; set; }

        public Action? OnEditor { get; set; }

        public Action? OnQuit { get; set; }
    }
}