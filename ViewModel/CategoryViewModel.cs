using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Test2.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }
        public CategoryViewModel()
        {
            Products = new Collection<ProductViewModel>();
        }
    }
}