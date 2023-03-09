namespace OfficeFlow.Core.Exceptions;

public class InvalidUserSurnameException : CustomException
{
    public string Surname { get; }

    public InvalidUserSurnameException(string surname) : base($"User surname: {surname} is invalid.")
    {
        Surname = surname;
    }
}
