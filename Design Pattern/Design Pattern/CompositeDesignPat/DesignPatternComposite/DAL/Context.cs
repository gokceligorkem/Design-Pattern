using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DesignPatternComposite.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CULE9C8; initial catalog=CompositeDP7; integrated security=true");
        }

       public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
