using OfficeFlow.Core.Entities;
using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record UserName
{
    public string Value { get; }

    public UserName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 50 or < 3)
        {
            throw new InvalidUserNameException(value);
        }
        
        Value = value;
    }

    public static implicit operator string(UserName name) => name.Value;
    public static implicit operator UserName(string name) => new(name);
    public override string ToString() => Value;
}
