using GuerraDeCartas.Domain.Common;

namespace GuerraDeCartas.Domain.Cards;

public abstract class UnitCard : Card
{
    public int Offensive { get; protected set; }
    public int Armor { get; protected set; }
    public UnitType UnitType { get; protected set; }

    protected UnitCard(
        string name,
        int offensive,
        int armor,
        UnitType unitType
    ) : base(name, CardType.Unit)
    {
        Offensive = offensive;
        Armor = armor;
        UnitType = unitType;
    }
}