using AspNet8.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
