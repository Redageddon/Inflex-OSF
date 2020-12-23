using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osuTK;
using osuTK.Graphics;

namespace Inflex_OSF.Screens
{
    public sealed class BackButton : BasicButton
    {
        public BackButton()
        {
            this.Anchor = Anchor.BottomLeft;
            this.Origin = Anchor.BottomLeft;
            this.Size = new Vector2(200, 100);
            this.BackgroundColour = new Color4(25, 25, 25, 255);
            this.SpriteText.Colour = Colour4.White;
            this.Text = "Back";
        }
    }
}