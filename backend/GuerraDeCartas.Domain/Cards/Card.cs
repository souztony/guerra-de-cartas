using GuerraDeCartas.Domain.Enums;
using GuerraDeCartas.Domain.Tactics;

namespace GuerraDeCartas.Domain.Cards;

public abstract class Card
{
    public Guid Id { get; }
    public string Name { get; }
    public CardType Type { get; }
    public Tactic Tactic { get; }
    public string Image { get; }

    protected Card(
        Guid id,
        string name,
        CardType type,
        Tactic tactic,
        string image)
    {
        Id = id;
        Name = name;
        Type = type;
        Tactic = tactic;
        Image = image;
    }
}
