namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidPeselException : CustomException
{
    public string Pesel { get; }

    public InvalidPeselException(string pesel) : base($"Pesel: {pesel} is invalid.")
    {
        Pesel = pesel;
    }
}
