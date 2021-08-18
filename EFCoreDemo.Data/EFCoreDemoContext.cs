using EFCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreDemo.Data
{
    public class EFCoreDemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory) // 顯示 SQL 語句
                .EnableSensitiveDataLogging() // 在顯示的 SQL 語句中，顯示帶入參數
                .UseSqlServer(
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

        // 顯示 SQL 語句
        public static readonly ILoggerFactory ConsoleLoggerFactory =
            LoggerFactory.Create(builder =>
            {
                builder.AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name
                        && level == LogLevel.Information)
                    .AddConsole();
            });
    }
}
