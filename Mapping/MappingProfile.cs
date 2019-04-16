using AutoMapper;
using Test2.DAL.Models;
using Test2.DAL.DTO;

namespace Test2.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();
        }
    }
}