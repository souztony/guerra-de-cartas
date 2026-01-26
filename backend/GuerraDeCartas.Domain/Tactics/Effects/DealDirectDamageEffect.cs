using GuerraDeCartas.Domain.Game;

namespace GuerraDeCartas.Domain.Tactics;

public sealed class DealDirectDamageEffect : Effect
{
    private readonly int _dano;

    public DealDirectDamageEffect(int dano)
    {
        _dano = dano;
    }

    public override void Execute(GameState gameState)
    {
        gameState.JogadorOponente.ReceberDano(_dano);
    }
}
