using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace angular6_dotnet22_example.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone { get; set; }
        [Required]
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public ICollection<Product> Products { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public bool IsFollowToNewsletter { get; set; }

        public Order()
        {
            Products = new Collection<Product>();
        }
    }
}