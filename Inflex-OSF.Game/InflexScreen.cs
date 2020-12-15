using osu.Framework.Input.Events;
using osu.Framework.Screens;
using osuTK.Input;

namespace Inflex_OSF.Game
{
    public class InflexScreen : Screen
    {
        protected override bool OnKeyDown(KeyDownEvent e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    this.Exit();
                    break;
            }

            return base.OnKeyDown(e);
        }
    }
}