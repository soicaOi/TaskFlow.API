namespace Application.Security.Dtos;

public record RegisterUserRequestDto(
    FullNameDto FullName,
    string UserName,
    string Email,
    string Password
);
