using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casgem_ObServer.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK\\SQLEXPRESS;database= DbObServer;integrated security = true");
        }

        public DbSet<WelcomeMessage> WelcomeMessageges { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<UserProses> UserProseses { get; set; }
    }
}