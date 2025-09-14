namespace Domain.ValueObjects;

public record ProjectMemberId
{
    public Guid Value { get; set; } = default!;

    private ProjectMemberId(Guid value)
    {
        Value = value;
    }

    public static ProjectMemberId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new CreateValueObjectException("Значение ProjectMemberId не должно быть пустым");
        }

        return new ProjectMemberId(value);
    }
}
