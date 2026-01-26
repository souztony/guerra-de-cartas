using GuerraDeCartas.Domain.Tactics;

namespace GuerraDeCartas.Domain.Cards;

public sealed class ResourceCard : Card
{
    public ResourceCard(
        Guid id,
        string name,
        Tactic tactic,
        string image)
        : base(id, name, Enums.CardType.Resource, tactic, image)
    {
    }
}
