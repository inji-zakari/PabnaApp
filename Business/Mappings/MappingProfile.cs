using AutoMapper;
using Core.Entities;
using Pabna.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pabna.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Color, ColorDto>().ReverseMap();
            //CreateMap<Product, ProductsWithLibraryDataDto>();
            //CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
