using System.IO.MemoryMappedFiles;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test2.DAL.DTO;
using Test2.Services;

namespace Test2.Controllers
{
    public class CategoriesController : Controller
    {
        readonly IDataService dataSvc;
        
        public CategoriesController(IDataService dataSvc)
        {
            this.dataSvc = dataSvc;
        }
        [HttpGet("/api/categories")]
        public async Task<IEnumerable<CategoryDto>> GetCategories()
        {
          return await dataSvc.GetCategories();
        }
    }
}