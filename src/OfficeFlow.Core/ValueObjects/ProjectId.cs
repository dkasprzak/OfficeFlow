using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public record ProjectId
{
    public Guid Value { get; }

    public ProjectId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidEntityIdException(value);
        }
        Value = value;
    }

    public static ProjectId Create() => new(Guid.NewGuid());
    public static implicit operator Guid(ProjectId projectId) => projectId.Value;
    public static implicit operator ProjectId(Guid projectId) => new(projectId);
}

