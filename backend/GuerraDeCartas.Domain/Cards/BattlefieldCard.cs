using GuerraDeCartas.Domain.Tactics;

namespace GuerraDeCartas.Domain.Cards;

public sealed class BattlefieldCard : Card
{
    public BattlefieldCard(
        Guid id,
        string name,
        Tactic tactic,
        string image)
        : base(id, name, Enums.CardType.Battlefield, tactic, image)
    {
    }
}
