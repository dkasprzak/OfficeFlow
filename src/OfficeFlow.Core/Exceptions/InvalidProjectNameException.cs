namespace OfficeFlow.Core.Exceptions;

public class InvalidProjectNameException : CustomException
{
    public InvalidProjectNameException() : base("Project name is invalid")
    {
    }
}
