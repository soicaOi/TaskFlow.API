namespace Domain.Exceptions;

public class RegisteredException : DomainException
{
    public RegisteredException(string message) : base(message)
    {
    }
}