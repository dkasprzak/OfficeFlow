using System.Text.RegularExpressions;
using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record Email
{
    public string Value { get; }

    private static readonly Regex Regex = new(
        @"^[a-z\d]+[\w\d.-]*[a-z\d]+@(?:[a-z\d]+[a-z\d-]+\.){1,3}[a-z]{2,4}$", 
        RegexOptions.Compiled
    );

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > 100)
        {
            throw new InvalidEmailException(value);
        }

        value = value.ToLowerInvariant();
        if (!Regex.IsMatch(value))
        {
            throw new InvalidEmailException(value);
        }
        
        Value = value;
    }

    public static implicit operator string(Email email) => email.Value;
    public static implicit operator Email(string email) => new(email);
    public override string ToString() => Value;
}
