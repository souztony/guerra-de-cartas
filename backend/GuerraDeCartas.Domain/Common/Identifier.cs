namespace GuerraDeCartas.Domain.Common;

public abstract class Identifier : ValueObject
{
    public Guid Value { get; }

    protected Identifier(Guid value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}