using Microsoft.EntityFrameworkCore;

namespace portfoljoAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PortrfolioAPI> PortrfolioAPIS { get; set; }
    }

}
