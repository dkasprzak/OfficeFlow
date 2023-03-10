namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidIdCardNumber : CustomException
{
    public string IdCardNumber { get; }
    
    public InvalidIdCardNumber(string idCardNumber) : base($"Id Card Number: {idCardNumber} is invalid.")
    {
        IdCardNumber = idCardNumber;
    }
}
