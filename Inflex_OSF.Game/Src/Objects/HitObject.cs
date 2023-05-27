using osu.Framework.Bindables;

namespace Infex_OSF.Game.Objects;

public class HitObject
{
    public readonly Bindable<double> StartTimeBindable = new BindableDouble();

    public virtual double StartTime
    {
        get => this.StartTimeBindable.Value;
        set => this.StartTimeBindable.Value = value;
    }
}