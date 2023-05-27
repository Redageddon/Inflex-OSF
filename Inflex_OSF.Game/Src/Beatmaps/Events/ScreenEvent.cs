namespace Infex_OSF.Game.Beatmaps.Events;

public record ScreenEvent : Event
{
    public int RotationSpeed { get; }

    public int Zoom { get; }
}