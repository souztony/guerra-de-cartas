namespace GuerraDeCartas.Domain.Cards;

public abstract class ResourceCard : Card
{
    protected ResourceCard(string name)
        : base(name, CardType.Resource)
    {
    }
}