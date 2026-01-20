using GuerraDeCartas.Domain.Common;

namespace GuerraDeCartas.Domain.Cards;

public abstract class Card : Entity
{
    public string Name { get; protected set; }
    public CardType Type { get; protected set; }
    public CardState State { get; protected set; }

    protected Card(string name, CardType type)
    {
        Name = name;
        Type = type;
        State = CardState.Deck;
    }

    protected void ChangeState(CardState newState)
    {
        State = newState;
    }
}