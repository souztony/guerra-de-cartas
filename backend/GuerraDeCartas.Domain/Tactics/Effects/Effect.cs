namespace GuerraDeCartas.Domain.Tactics;

public abstract class Effect
{
    public abstract void Execute(Game.GameState gameState);
}
