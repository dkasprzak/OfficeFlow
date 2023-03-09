using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record Login
{
    public string Value { get; }

    public Login(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 30 or < 3)
        {
            throw new InvalidLoginException(value);
        }
        Value = value;
    }

    public static implicit operator string(Login login) => login.Value;
    public static implicit operator Login(string login) => new(login);
    public override string ToString() => Value;
}