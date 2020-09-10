using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osuTK;
using osuTK.Graphics;

namespace Game.Game.MainMenu
{
    public sealed class MainMenuButton : ClickableContainer
    {
        public MainMenuButton(string text, Action buttonAction, Color4 color)
        {
            this.Children = new Drawable[]
            {
                this.Button = new BasicButton
                {
                    Colour = color,
                    AlwaysPresent = true,
                    Size = new Vector2(200, 200),
                    Action = buttonAction,
                },
                new SpriteText
                {
                    Colour = new Color4(255, 255, 255, 255),
                    Text = text,
                },
            };
        }

        public Button Button { get; set; }
    }
}