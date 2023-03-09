using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record ProjectName
{
    public string Value { get; }

    public ProjectName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new InvalidProjectNameException();
        }
        
        Value = value;
    }

    public static implicit operator string(ProjectName projectName) => projectName.Value;
    public static implicit operator ProjectName(string projectName) => new(projectName);
}
