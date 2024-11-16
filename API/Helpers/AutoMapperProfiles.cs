using System;
using API.DTO;
using API.Extensions;
using API.Models;
using AutoMapper;

namespace API.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppUser,MemberDto>()
        .ForMember(d => d.Age, o=> o.MapFrom(s => s.DateOfBirth.CalculatAge()))
            .ForMember(d => d.PhotoUrl, o => 
                o.MapFrom(s => s.Photos.FirstOrDefault(x => x.IsMain)!.Url));
        CreateMap<Photo, PhotoDto>();
    }
}