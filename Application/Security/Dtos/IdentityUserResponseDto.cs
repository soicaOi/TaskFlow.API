namespace Application.Security.Dtos;

public record IdentityUserResponseDto(
    string Id,
    string UserName,
    string Email,
    string JwtToken
);
