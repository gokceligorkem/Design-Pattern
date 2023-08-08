using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ChainofResponsibilityDesignPat.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CULE9C8; initial catalog=ChainResDP1; integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcess { get; set; }
    }
}
