namespace GuerraDeCartas.Domain.Cards;

public abstract class BattlefieldCard : Card
{
    protected BattlefieldCard(string name)
        : base(name, CardType.Battlefield)
    {
    }
}