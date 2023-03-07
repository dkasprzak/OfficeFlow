using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public class ProjectOwnerId
{
    public Guid Value { get; }

    public ProjectOwnerId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidEntityIdException(value);
        }
        Value = value;
    }

    public static ProjectOwnerId Create() => new(Guid.NewGuid());
    public static implicit operator Guid(ProjectOwnerId projectOwnerId) => projectOwnerId.Value;
    public static implicit operator ProjectOwnerId(Guid projectOwnerId) => new(projectOwnerId);
}
