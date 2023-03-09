namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidProjectNameException : CustomException
{
    public InvalidProjectNameException() : base("Project name is invalid")
    {
    }
}
