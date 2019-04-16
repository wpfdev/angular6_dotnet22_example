using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Test2.DAL.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<ProductDto> Products { get; set; }
        public CategoryDto()
        {
            Products = new Collection<ProductDto>();
        }
    }
}