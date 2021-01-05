using System;
using JetBrains.Annotations;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Input;
using osuTK;
using X10D;

namespace Infex_OSF.Game.Screens.Pointer
{
    public class PointerSystem : Container
    {
        private readonly Sprite center;
        private readonly Sprite pointer;
        [NotNull]
        private InputManager inputManager;

        public PointerSystem()
        {
            this.Children = new[]
            {
                this.center = new Sprite
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                },
                this.pointer = new Sprite
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                },
            };
        }

        protected override void Update()
        {
            this.pointer.Rotation = this.GetPointerRotation();
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();
            this.inputManager = this.GetContainingInputManager()!;
        }

        private float GetPointerRotation()
        {
            Vector2 localPosition = this.ToLocalSpace(this.inputManager.CurrentState.Mouse.Position);
            return MathF.Atan2(localPosition.X, -localPosition.Y).RadiansToDegrees();
        }

        [BackgroundDependencyLoader]
        private void Load(TextureStore textures)
        {
            this.center.Texture = textures.Get("Center");
            this.pointer.Texture = textures.Get("Pointer");
        }
    }
}