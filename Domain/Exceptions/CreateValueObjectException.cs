namespace Domain.Exceptions;

public class CreateValueObjectException : DomainException
{
    public CreateValueObjectException(string message) : base($"Ошибка при создании объекта: [{message}]")
    {
        
    }
}
