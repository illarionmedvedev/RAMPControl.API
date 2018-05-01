using AutoMapper;
using RAMPControl.API.Dtos;
using RAMPControl.API.Models;

namespace RAMPControl.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();

            
        }
    }
}