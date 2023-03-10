namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidPostalCodeException : CustomException
{
    public string PostalCode { get; }
    
    public InvalidPostalCodeException(string postalCode) : base($"Postal code: {postalCode} is invalid.")
    {
        PostalCode = postalCode;
    }
}
