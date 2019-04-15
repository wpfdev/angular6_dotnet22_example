using Microsoft.EntityFrameworkCore;
using angular6_dotnet22_example.Models;
using Microsoft.Extensions.Configuration;

namespace angular6_dotnet22_example.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
           
        }
    
        public DbSet<Option> Options { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}