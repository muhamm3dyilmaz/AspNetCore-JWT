using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace TokenAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
