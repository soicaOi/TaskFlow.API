namespace Domain.ValueObjects;

public record CommentId
{
    public Guid Value { get; set; } = default!;

    private CommentId(Guid value)
    {
        Value = value;
    }

    public static CommentId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new CreateValueObjectException("Значение CommentId не должно быть пустым");
        }

        return new CommentId(value);
    }
}
