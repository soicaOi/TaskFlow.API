namespace Domain.ValueObjects;

public record FullName
{
    public string FirstName { get; } = default!;
    public string LastName { get; } = default!;
    public string? MiddleName { get; }

    private FullName(string firstName, string lastName, string? middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }

    public static FullName Of(string firstName, string lastName, string? middleName)
    {
        ArgumentException.ThrowIfNullOrEmpty(firstName);
        ArgumentException.ThrowIfNullOrEmpty(lastName);

        return new FullName(firstName, lastName, middleName);
    }
}
