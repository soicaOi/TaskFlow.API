using Application.Security.Dtos;
using AutoMapper;
using Domain.ValueObjects;

namespace Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterUserRequestDto, CustomIdentityUser>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => FullName.Of(
                src.FullName.FirstName,
                src.FullName.LastName,
                src.FullName.MiddleName
            )));
    }
}
