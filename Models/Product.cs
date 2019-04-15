using System.Collections;

namespace angular6_dotnet22_example.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Option> Options { get; set; }

        public Product()
        {
            Options = new Collection<Option>();
        }
    }
}