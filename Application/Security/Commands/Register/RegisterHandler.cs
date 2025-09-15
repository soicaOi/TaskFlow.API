using Application.Security.Dtos;

namespace Application.Security.Commands.Register;

public class RegisterHandler(UserManager<CustomIdentityUser> manager, IJwtSecurityService jwtSecurityService, IMapper mapper)
    : ICommandHandler<RegisterCommand, RegisterResult>
{
    public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var dto = request.dto;

        if (await manager.Users.AnyAsync(u => u.NormalizedUserName == dto.UserName.ToUpper()))
        {
            throw new UsernameAlreadyRegisteredException(dto.UserName);
        }

        if (await manager.Users.AnyAsync(u => u.NormalizedEmail == dto.Email.ToUpper()))
        {
            throw new EmailAlreadyRegisteredException(dto.Email);
        }

        var user = mapper.Map<CustomIdentityUser>(dto);

        var result = await manager.CreateAsync(user, dto.Password!);

        if (result.Succeeded)
        {
            var response = new IdentityUserResponseDto(
                user.Id,
                dto.UserName,
                dto.Email,
                jwtSecurityService.CreateToken(user)
            );

            return new RegisterResult(response);
        }

        throw new RegisteredException(string.Join(", ", result.Errors));
    }
}
