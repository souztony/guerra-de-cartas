using GuerraDeCartas.Domain.Tactics;

namespace GuerraDeCartas.Domain.Cards;

public sealed class StrategyCard : Card
{
    public StrategyCard(
        Guid id,
        string name,
        Tactic tactic,
        string image)
        : base(id, name, Enums.CardType.Strategy, tactic, image)
    {
    }
}
