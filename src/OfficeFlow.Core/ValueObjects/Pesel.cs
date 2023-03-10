using System.Text.RegularExpressions;
using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record Pesel
{
    private static readonly Regex Regex = new(
        @"^[\d]{11}$",
        RegexOptions.Compiled
    );
    public string Value { get; }

    public Pesel(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidPeselException(value);
        }

        if (!Regex.IsMatch(value))
        {
            throw new InvalidPeselException(value);
        }
        
        Value = value;
    }

    public static implicit operator string(Pesel pesel) => pesel.Value;
    public static implicit operator Pesel(string pesel) => new(pesel);
    public override string ToString() => Value;
}
