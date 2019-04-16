using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Option> Options { get; set; }

        public Product()
        {
            Options = new Collection<Option>();
        }
    }
}