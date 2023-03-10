using System.Text.RegularExpressions;
using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record IdCardNumber
{
    private static readonly Regex Regex = new(
        @"^[a-z]{3}[\d]{6}|[a-z]{3}\s?[\d]{3}\s?[\d]{3}$",
        RegexOptions.Compiled
        );

    public string Value { get; }

    public IdCardNumber(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new InvalidIdCardNumber(value);
        }

        value = value.ToUpperInvariant();
        if (!Regex.IsMatch(value))
        {
            throw new InvalidIdCardNumber(value);
        }

        Value = value;
    }

    public static implicit operator string(IdCardNumber idCardNumber) => idCardNumber.Value;
    public static implicit operator IdCardNumber(string idCardNumber) => new(idCardNumber);
    public override string ToString() => Value;
}
