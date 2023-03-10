using System.Text.RegularExpressions;
using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record PostalCode
{
    private static readonly Regex Regex = new(
        @"^[\d]{2}-[\d]{3}$",
        RegexOptions.Compiled
    ); 
    
    public string Value { get; }

    public PostalCode(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidPostalCodeException(value);
        }

        if (!Regex.IsMatch(value))
        {
            throw new InvalidPostalCodeException(value);
        }
        
        Value = value;
    }

    public static implicit operator string(PostalCode postalCode) => postalCode.Value;
    public static implicit operator PostalCode(string postalCode) => new(postalCode);
    public override string ToString() => Value;
}
