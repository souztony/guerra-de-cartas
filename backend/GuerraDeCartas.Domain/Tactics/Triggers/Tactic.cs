using GuerraDeCartas.Domain.Tactics.Triggers;

namespace GuerraDeCartas.Domain.Tactics;

public sealed class Tactic
{
    public TacticType Type { get; }
    public TriggerType? Trigger { get; }
    public Effect Effect { get; }

    public Tactic(
        TacticType type,
        Effect effect,
        TriggerType? trigger = null)
    {
        Type = type;
        Effect = effect;
        Trigger = trigger;
    }
}
