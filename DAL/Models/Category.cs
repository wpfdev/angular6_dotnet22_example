using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.DAL.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new Collection<Product>();
        }
    }
}