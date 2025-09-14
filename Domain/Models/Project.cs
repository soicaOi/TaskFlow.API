namespace Domain.Models;

public class Project : Entity<ProjectId>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public List<ProjectMember> Members { get; set; } = [];
}
