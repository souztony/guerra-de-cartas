namespace GuerraDeCartas.Domain.Tactics.Events;

public sealed class GameEvent
{
    public GameEventType Type { get; }
    public object? Source { get; }

    public GameEvent(GameEventType type, object? source = null)
    {
        Type = type;
        Source = source;
    }
}
