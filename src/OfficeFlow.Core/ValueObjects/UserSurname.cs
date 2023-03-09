using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record UserSurname
{
    private string Value { get; }

    public UserSurname(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 50 or < 3)
        {
            throw new InvalidUserSurnameException(value);
        }
        Value = value;
    }

    public static implicit operator string(UserSurname surname) => surname.Value;
    public static implicit operator UserSurname(string surname) => new(surname);
    public override string ToString() => Value;
}
