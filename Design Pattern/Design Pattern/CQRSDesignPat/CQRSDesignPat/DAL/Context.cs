using Microsoft.EntityFrameworkCore;

namespace CQRSDesignPat.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CULE9C8; initial catalog=CQRSDP2; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
