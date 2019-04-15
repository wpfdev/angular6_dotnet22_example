using System.IO.MemoryMappedFiles;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test2.ViewModel;
using Test2.Models;
using Test2.DAL;
using AutoMapper;

namespace Test2.Controllers
{
    public class CategoriesController : Controller
    {
        readonly AppDbContext context;
        readonly IMapper mapper;
        public CategoriesController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/categories")]
        public async Task<IEnumerable<CategoryViewModel>> GetCategories()
        {
            var categories = await context.Categories.Include(c=> c.Products).ToListAsync();
            return mapper.Map<List<Category>, List<CategoryViewModel>>(categories);
        }
    }
}