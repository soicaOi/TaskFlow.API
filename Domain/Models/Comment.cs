namespace Domain.Models;

public class Comment : Entity<CommentId>
{
    public string Text { get; set; } = default!;
    public Issue CurrentIssue { get; set; } = default!;
    public CustomIdentityUser Author { get; set; } = default!;
}
