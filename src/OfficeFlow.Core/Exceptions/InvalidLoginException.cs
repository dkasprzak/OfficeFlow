namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidLoginException : CustomException
{
    public string Login { get; }

    public InvalidLoginException(string login) : base($"User login: {login} is invalid.")
    {
        Login = login;
    }
}
