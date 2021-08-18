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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 聯合外鍵 (m:n)
            modelBuilder.Entity<GamePlayer>()
                .HasKey(g => new {g.PlayerId, g.GameId});
            // (1:1)
            modelBuilder.Entity<Resume>()
                .HasOne(r => r.Player)
                .WithOne(p => p.Resume)
                .HasForeignKey<Resume>(r => r.PlayerId);

        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
