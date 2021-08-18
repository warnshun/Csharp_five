using EFCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class EFCoreDemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=EFCoreDemo");
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
