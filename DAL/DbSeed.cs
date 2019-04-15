using angular6_dotnet22_example.Models;
using System.Linq;

namespace angular6_dotnet22_example.DAL
{
    /// <summary>
    /// Initialize data 
    /// </summary>
    public class DbSeed
    {
        AppDbContext _context;
        public DbSeed(AppDbContext context)
        {
            _context = context;
        }
        public void DoSeedData(){
            if(_context.Products.Count() > 0)
                return;

            var prod1 = new Product {
                Id = 1,
                Name = "Business CRM"
            };
            _context.Products.Add(prod1);
            var prod2 = new Product {
                Id = 2,
                Name = "Mobile Application"
            };
            _context.Products.Add(prod2);
            var opt1 = new Option {
                Id = 1,
                Name = "For Small Teams",
                ProductId = 1
            };
            _context.Options.Add(opt1);
            var opt2 = new Option {
                Id = 2,
                Name = "Advanced CRM",
                ProductId = 1
            };
            _context.Options.Add(opt2);
            var opt3 = new Option {
                Id = 3,
                Name = "Android",
                ProductId = 2
            };
            _context.Options.Add(opt3);
            var opt4 = new Option {
                Id = 4,
                Name = "iOS",
                ProductId = 2
            };
            _context.Options.Add(opt4);
            var opt5 = new Option {
                Id = 5,
                Name = "iOS + Android",
                ProductId = 2
            };
            _context.Options.Add(opt5);
            _context.SaveChanges();
        }
    }
}