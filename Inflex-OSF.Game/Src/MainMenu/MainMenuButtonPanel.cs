using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;

namespace Inflex_OSF.Game.MainMenu
{
    public class MainMenuButtonPanel : Container
    {
        private readonly Vector2 buttonSize = new Vector2(200, 100);

        public MainMenuButtonPanel(Action onPlay, Action onMultiplayer, Action onSettings, Action onEditor, Action onQuit) =>
            this.Child = new VerticalHolder
            {
                Children = new[]
                {
                    new MainMenuButton("Play", Colour4.Red, this.buttonSize, onPlay),
                    new MainMenuButton("Multiplayer", Colour4.Orange, this.buttonSize, onMultiplayer),
                    new MainMenuButton("Settings", Colour4.Yellow, this.buttonSize, onSettings),
                    new MainMenuButton("Editor", Colour4.Green, this.buttonSize, onEditor),
                    new MainMenuButton("Quit", Colour4.Blue, this.buttonSize, onQuit),
                },
            };
    }
}