namespace Domain.Exceptions;

public class UsernameAlreadyRegisteredException : RegisteredException
{
    public string Username { get; }
    public UsernameAlreadyRegisteredException(string username)
        : base($"Имя пользователя ({username}) уже занято")
    {
        Username = username;
    }
}