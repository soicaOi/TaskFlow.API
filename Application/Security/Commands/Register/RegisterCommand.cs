using Application.Security.Dtos;
using Shared.SQRS;

namespace Application.Security.Commands.Register;

public record RegisterCommand(RegisterUserRequestDto dto) : ICommand<RegisterResult>;

public record RegisterResult(IdentityUserResponseDto Result);
