using System;
using osu.Framework.Allocation;
using osu.Framework.Audio;
using osu.Framework.Audio.Sample;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Events;
using osuTK;
using osuTK.Graphics;

namespace Infex_OSF.Game.Screens.MainMenu
{
    public sealed class MainMenuButton : ClickableContainer
    {
        private const Anchor HoverAnchor = Anchor.CentreLeft;

        private readonly Container mainImage;
        private readonly Action onPressed;
        private readonly Box onPressedMask;

        private SampleChannel? clickSound;
        private SampleChannel? hoverSound;

        public MainMenuButton(string text, Color4 buttonColor, Vector2 size, Action onPressed)
        {
            this.onPressed = onPressed;
            this.Size = size;

            this.Children = new Drawable[]
            {
                // Button back image
                this.mainImage = new Container
                {
                    RelativeSizeAxes = Axes.Both,
                    Origin = HoverAnchor,
                    Anchor = HoverAnchor,
                    Children = new[]
                    {
                        new Box
                        {
                            Colour = buttonColor,
                            RelativeSizeAxes = Axes.Both,
                        },
                        this.onPressedMask = new Box
                        {
                            Alpha = 0,
                            Colour = Color4.White,
                            RelativeSizeAxes = Axes.Both,
                        },
                    },
                },

                // Button text
                new Container
                {
                    RelativeSizeAxes = Axes.Both,
                    Child = new SpriteText
                    {
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                        Colour = Colour4.Black,
                        Text = text,
                    },
                },
            };
        }

        // Makes mouse detection work on this thingy
        public override bool ReceivePositionalInputAt(Vector2 screenSpacePos) => this.mainImage.ReceivePositionalInputAt(screenSpacePos);

        public void MoveIntoPlace(Vector2 position, int moveInTime, bool movingIn)
        {
            foreach (var drawable in this.Children)
            {
                if (movingIn)
                {
                    drawable.MoveTo(position)?.MoveTo(Vector2.Zero, moveInTime + 300, Easing.InCirc);
                }
                else
                {
                    drawable.MoveTo(Vector2.Zero)?.MoveTo(position, moveInTime, Easing.InCirc);
                }
            }
        }

        protected override bool OnHover(HoverEvent e)
        {
            this.hoverSound?.Play();
            this.mainImage.ScaleTo(new Vector2(1.3f, 1.05f), 500, Easing.OutElastic);

            return base.OnHover(e);
        }

        protected override void OnHoverLost(HoverLostEvent e) => this.mainImage.ScaleTo(Vector2.One, 500, Easing.OutElastic);

        protected override bool OnMouseDown(MouseDownEvent e)
        {
            this.onPressedMask.FadeTo(0.5f, 1000, Easing.OutQuint);

            return base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseUpEvent e)
        {
            this.onPressedMask.FadeTo(0, 1000, Easing.OutQuint);

            base.OnMouseUp(e);
        }

        protected override bool OnClick(ClickEvent e)
        {
            MainMenuButtonPanel.StartingFlow = ((FillFlowContainer)this.Parent).IndexOf(this);

            this.clickSound?.Play();

            this.onPressed.Invoke();

            return base.OnClick(e);
        }

        [BackgroundDependencyLoader]
        private void Load(AudioManager audio)
        {
            this.hoverSound = audio.Samples?.Get("hover");
            this.clickSound = audio.Samples?.Get("click");
        }
    }
}