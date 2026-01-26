namespace GuerraDeCartas.Domain.Game;

public sealed class GameState
{
    public Player JogadorAtual { get; private set; }
    public Player JogadorOponente { get; private set; }

    public GameState(Player jogador1, Player jogador2)
    {
        JogadorAtual = jogador1;
        JogadorOponente = jogador2;
    }

    public void TrocarTurno()
    {
        (JogadorAtual, JogadorOponente) =
            (JogadorOponente, JogadorAtual);
    }
}
