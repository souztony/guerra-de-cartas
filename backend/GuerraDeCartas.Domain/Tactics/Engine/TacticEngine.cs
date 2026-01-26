using GuerraDeCartas.Domain.Game;
using GuerraDeCartas.Domain.Tactics.Events;

namespace GuerraDeCartas.Domain.Tactics.Engine;

public sealed class TacticEngine
{
    public void ProcessEvent(
        GameEvent gameEvent,
        IEnumerable<Tactic> tactics,
        GameState gameState)
    {
        foreach (var tactic in tactics)
        {
            if (!CanTrigger(tactic, gameEvent))
                continue;

            tactic.Effect.Execute(gameState);
        }
    }

    private bool CanTrigger(Tactic tactic, GameEvent gameEvent)
    {
        if (tactic.Type != TacticType.Reactive)
            return false;

        if (!tactic.Trigger.HasValue)
            return false;

        return tactic.Trigger.Value switch
        {
            Triggers.TriggerType.OnDestroyed
                => gameEvent.Type == GameEventType.UnitDestroyed,

            Triggers.TriggerType.OnAttackDeclared
                => gameEvent.Type == GameEventType.AttackDeclared,

            _ => false
        };
    }
}
