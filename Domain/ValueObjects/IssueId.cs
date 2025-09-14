namespace Domain.ValueObjects;

public record IssueId
{
    public Guid Value { get; set; } = default!;

    private IssueId(Guid value)
    {
        Value = value;
    }

    public static IssueId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new CreateValueObjectException("Значение IssueId не должно быть пустым");
        }

        return new IssueId(value);
    }
}