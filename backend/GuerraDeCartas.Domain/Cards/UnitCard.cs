using GuerraDeCartas.Domain.Enums;
using GuerraDeCartas.Domain.Tactics;

namespace GuerraDeCartas.Domain.Cards;

public sealed class UnitCard : Card
{
    public UnitCategory Categoria { get; }
    public int Ofensiva { get; }
    public int Blindagem { get; }

    public UnitCard(
        Guid id,
        string name,
        UnitCategory categoria,
        int ofensiva,
        int blindagem,
        Tactic tactic,
        string image)
        : base(id, name, CardType.Unit, tactic, image)
    {
        Categoria = categoria;
        Ofensiva = ofensiva;
        Blindagem = blindagem;
    }
}
