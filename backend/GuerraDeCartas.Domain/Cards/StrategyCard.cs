namespace GuerraDeCartas.Domain.Cards;

public abstract class StrategyCard : Card
{
    protected StrategyCard(string name)
        : base(name, CardType.Strategy)
    {
    }
}