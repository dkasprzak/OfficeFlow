using System.Text.RegularExpressions;
using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record PhoneNumber
{
    private static readonly Regex Regex = new(
        @"^([\d]{9}|[\d]{3}\s[\d]{3}\s[\d]{3})$",
        RegexOptions.Compiled
    );

    public string Value { get; }

    public PhoneNumber(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new InvalidPhoneNumberException(value);
        }

        if (IsWhiteSpace(value))
        {
            value = value.Replace(" ", "");
        }

        if (!Regex.IsMatch(value))
        {
            throw new InvalidPhoneNumberException(value);
        }
        
        Value = value;
    }
    
    public static implicit operator string(PhoneNumber phoneNumber) => phoneNumber.Value;
    public static implicit operator PhoneNumber(string phoneNumber) => new(phoneNumber);
    public override string ToString() => Value;

    private static bool IsWhiteSpace(string value)
    {
        for (int i = 0; i < value.Length; i++)
        {
            if (!char.IsWhiteSpace(value[i])) return false;
        }

        return true;
    }
}
