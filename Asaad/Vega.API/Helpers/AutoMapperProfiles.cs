using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using Vega.API.Dtos;
using Vega.API.Models;

namespace Vega.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles ()
        {
            CreateMap<User, UserForDetailedDto> ()
                .ForMember (dest => dest.PhotoUrl, opt =>
                {
                    opt.MapFrom (src => src.Photos.FirstOrDefault (p => p.IsMain).Url);
                })
                .ForMember (dest => dest.Age, opt =>
                {
                    opt.ResolveUsing (d => d.DateOfBirth.CalculateAge ());
                });
            CreateMap<User, UserForListDto> ()
                .ForMember (dest => dest.PhotoUrl, opt =>
                {
                    opt.MapFrom (src => src.Photos.FirstOrDefault (p => p.IsMain).Url);
                })
                .ForMember (dest => dest.Age, opt =>
                {
                    opt.ResolveUsing (d => d.DateOfBirth.CalculateAge ());
                });

            CreateMap<Photo, PhotosForDetailedDto> ();

            CreateMap<PhotoForCreationDto, Photo> ();

            CreateMap<Photo, PhotoForReturnDto> ();

            CreateMap<UserForUpdateDto, User> ();

            CreateMap<UserForRegisterDto,User>();
        }
    }
}