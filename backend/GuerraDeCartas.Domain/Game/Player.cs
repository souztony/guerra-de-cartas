namespace GuerraDeCartas.Domain.Game;

public sealed class Player
{
    public Guid Id { get; }
    public int Vida { get; private set; }

    public Player(Guid id)
    {
        Id = id;
        Vida = 2000;
    }

    public void ReceberDano(int dano)
    {
        Vida -= dano;
        if (Vida < 0)
            Vida = 0;
    }
}
