using System;
using osu.Framework.Graphics.Containers;
using osuTK;
using osuTK.Graphics;

namespace Inflex_OSF.Game.MainMenu
{
    public class MainMenuButtonPanel : Container
    {
        private readonly MainMenuButton[] buttons;
        private readonly Vector2 buttonSize = new (200, 100);

        public MainMenuButtonPanel(Action onPlay, Action onMultiplayer, Action onSettings, Action onEditor, Action onQuit) =>
            this.Child = new VerticalHolder
            {
                Children = this.buttons = new MainMenuButton[]
                {
                    new ("Play", Color4.Red, this.buttonSize, onPlay),
                    new ("Multiplayer", Color4.Orange, this.buttonSize, onMultiplayer),
                    new ("Settings", Color4.Yellow, this.buttonSize, onSettings),
                    new ("Editor", Color4.Green, this.buttonSize, onEditor),
                    new ("Quit", Color4.Blue, this.buttonSize, onQuit),
                },
            };

        public static int StartingFlow { get; set; }

        public void FlowToPosition(bool movingIn)
        {
            int timing = 50;
            int beginning = StartingFlow;
            int ending = StartingFlow;

            this.buttons[StartingFlow].MoveIntoPlace(new Vector2(-400, 0), timing, movingIn);
            timing += 50;

            for (int i = 1; i < this.buttons.Length; i++)
            {
                if (beginning > 0)
                {
                    this.buttons[--beginning].MoveIntoPlace(new Vector2(-400, 0), timing, movingIn);
                }

                if (ending < this.buttons.Length - 1)
                {
                    this.buttons[++ending].MoveIntoPlace(new Vector2(-400, 0), timing, movingIn);
                }

                timing += 50;
            }
        }
    }
}