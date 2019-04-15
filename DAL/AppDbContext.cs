using Microsoft.EntityFrameworkCore;

namespace angular6_dotnet22_example.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            
        }
    }
}