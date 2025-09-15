namespace Domain.Exceptions;

public class EmailAlreadyRegisteredException : RegisteredException
{
    public string Email { get; }
    public EmailAlreadyRegisteredException(string email)
        : base($"Email ({email}) уже занят")
    {
        Email = email;
    }
}