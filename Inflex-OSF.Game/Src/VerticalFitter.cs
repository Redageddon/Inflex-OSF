using Game.Game.Utilities;
using osu.Framework.Allocation;
using osu.Framework.Extensions.IEnumerableExtensions;
using osu.Framework.Graphics.Containers;
using osuTK;

namespace Game.Game
{
    public class VerticalFitter : Container
    {
        private readonly int spacing;

        public VerticalFitter(int spacing = 0)
        {
            this.spacing = spacing;
        }

        [BackgroundDependencyLoader]
        private void Load()
        {
            if (this.Children is null)
            {
                throw new NullDependencyException($"{nameof(this.Children)} is null.");
            }

            var childrenCount = this.Children.Count;
            var fillSize = new Vector2(this.Size.X, (this.Size.Y / childrenCount) - this.spacing);

            for (var index = 0; index < childrenCount; index++)
            {
                var child = (Container)this.Children[index].CastNotNull("child");
                child.Children.ForEach(e => e!.Size = fillSize);
                child.Position = new Vector2(0, (index * (fillSize.Y + this.spacing)) + (this.spacing / 2));
            }
        }
    }
}