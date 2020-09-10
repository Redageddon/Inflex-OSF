using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Screens;

namespace Game.Game.MainMenu
{
    /// <inheritdoc />
    public class MainMenuScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void Load(TextureStore loadedTextures)
        {
            this.InternalChildren = new Drawable[]
            {
                new Background(),
                new MainMenuButtonSystem
                {
                    Anchor = Anchor.Centre,
                    OnBeatmapSelector = null,
                    OnEditor = null,
                    OnMulti = null,
                    OnQuit = null,
                    OnSettings = null,
                },
                new SpriteText
                {
                    Y = 20,
                    Text = "Main Screen",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 40),
                },
            };
        }
    }
}