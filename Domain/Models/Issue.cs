namespace Domain.Models;

public class Issue: Entity<Issue>
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public IssueStatus Status { get; set; } = default!;
    public IssuePriority Priority { get; set; } = default!;
    public DateTimeOffset? DueDate { get; set; } = default!;
    public Project CurrentProject { get; set; } = default!;
    public CustomIdentityUser Author { get; set; } = default!;
    public CustomIdentityUser? Executor { get; set; } = default!;
    public List<string> Labels { get; set; } = [];
}
