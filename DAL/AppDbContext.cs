using Microsoft.EntityFrameworkCore;
using Test2.DAL.Models;
using Microsoft.Extensions.Configuration;

namespace Test2.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
           
        }
    
        public DbSet<Option> Options { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories {get;set;}
    }
}