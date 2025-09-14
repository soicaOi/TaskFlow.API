namespace Domain.Models;

public class ProjectMember
{
    public required string UserId { get; set; }
    public required CustomIdentityUser CurrenUser { get; set; }

    public required ProjectId ProjectId { get; set; }
    public required Project CurrentProject { get; set; }

    public ProjectRole RoleInProject { get; set; }
}
