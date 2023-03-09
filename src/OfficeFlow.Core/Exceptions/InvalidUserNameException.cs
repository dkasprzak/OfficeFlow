namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidUserNameException : CustomException
{
    public string Name { get; }
    
    public InvalidUserNameException(string name) : base($"User name: {name} is invalid.")
    {
        Name = name;
    }
}
