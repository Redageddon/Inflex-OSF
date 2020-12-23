using osu.Framework.Graphics;
using osu.Framework.Input.Events;
using osu.Framework.Screens;
using osuTK.Input;

namespace Inflex_OSF.Screens
{
    public class InflexScreen : Screen
    {
        private readonly BackButton backButton;
        private bool backButtonEnabled = true;

        protected InflexScreen() =>
            this.AddInternal(
                 this.backButton = new BackButton
                {
                    Action = this.Exit,
                });

        public bool BackButtonEnabled
        {
            get => this.backButtonEnabled;
            set
            {
                this.backButton.Alpha = value ? 255 : 0;
                this.backButtonEnabled = value;
            }
        }

        public override void OnEntering(IScreen last) => this.FadeInFromZero(250);

        public override void OnResuming(IScreen last) => this.OnEntering(last);

        public override bool OnExiting(IScreen next)
        {
            this.FadeOut(250);
            return base.OnExiting(next);
        }

        public override void OnSuspending(IScreen next) => this.OnExiting(next);

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