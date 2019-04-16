using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.DAL.DTO;

namespace Test2.Services
{
    public interface IDataService
    {
         Task<IEnumerable<CategoryDto>> GetCategories();
         Task<IEnumerable<ProductDto>> GetProducts();
    }
}