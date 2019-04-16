using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Test2.DAL;
using Test2.DAL.DTO;
using Test2.DAL.Models;

namespace Test2.Services
{
    public class DataService : IDataService
    {
        AppDbContext context;
        IMapper mapper;
        public DataService(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CategoryDto>> GetCategories()
        {
            var categories = await context.Categories.Include(c=> c.Products).ToListAsync();
            return mapper.Map<List<Category>, List<CategoryDto>>(categories);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var prods = await context.Products.Include(c=> c.Options).ToListAsync();
            return mapper.Map<List<Product>, List<ProductDto>>(prods);
        }
    }
}