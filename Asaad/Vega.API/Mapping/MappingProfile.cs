using AutoMapper;
using Vega.api.Models;
using Vega.api.Resources;

namespace Vega.api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model,ModelResource>();

        }
    }
}