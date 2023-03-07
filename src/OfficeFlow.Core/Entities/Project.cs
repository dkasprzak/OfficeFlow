using OfficeFlow.Core.Enums;
using OfficeFlow.Core.ValueObjects;

namespace OfficeFlow.Core.Entities;

public class Project
{
    public ProjectId Id { get; private set; }
    public ProjectName ProjectName { get; private set; }
    public ProjectStatus Status { get; private set; }
    public CreatedDate CreatedDate { get; private set; }
    public UpdatedDate UpdatedDate { get; private set; }
    public CityId CityId { get; private set; }
    public ProjectOwnerId ProjectOwnerId { get; private set; }

    public Project(ProjectId id, ProjectName projectName, ProjectStatus status)
    {
        Id = id;
        ProjectName = projectName;
        Status = status;
    }
}
