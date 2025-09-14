namespace Domain.Abstractions;

public class Entity<T> : IEntity<T>
{
    public T Id { get; set; } = default!;
    public DateTimeOffset CreateAt { get; set; } = default!;
    public DateTimeOffset? UpdateAt { get; set; }
    public bool IsDeleted { get; set; } = default!;
    public DateTimeOffset? DeleteAt { get; set; }
}
