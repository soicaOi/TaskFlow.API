namespace Domain.ValueObjects;

public record ProjectId
{
    public Guid Value { get; set; } = default!;

    private ProjectId(Guid value)
    {
        Value = value;
    }

    public static ProjectId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new CreateValueObjectException("Значение ProjectId не должно быть пустым");
        }

        return new ProjectId(value);
    }
}
