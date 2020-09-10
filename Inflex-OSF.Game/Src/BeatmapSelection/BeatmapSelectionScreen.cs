using Game.Game.MainMenu;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Screens;

namespace Game.Game.Screens
{
    /// <inheritdoc />
    public class BeatmapSelectionScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void Load(TextureStore loadedTextures) =>
            this.InternalChildren = new Drawable[]
            {
                new SpriteText
                {
                    Y = 20,
                    Text = "Beatmap Selection",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 40),
                },
            };
    }
}