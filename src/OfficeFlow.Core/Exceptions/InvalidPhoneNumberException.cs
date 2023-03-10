namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidPhoneNumberException : CustomException
{
    public string PhoneNumber { get; }
    
    public InvalidPhoneNumberException(string phoneNumber) : base($"Phone number: {phoneNumber} is invalid.")
    {
        PhoneNumber = phoneNumber;
    }
}
