using Microsoft.EntityFrameworkCore;

namespace OyunDukkani.Data
{
    public class OyunlarContext : DbContext
    {
        public OyunlarContext(DbContextOptions<OyunlarContext> options) : base(options)
        {

        }
        public DbSet<Oyunlar> oyunlar => Set<Oyunlar>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oyunlar>().HasData(
                 new Oyunlar {Id=1, OyunAdi = "The Witcher 3", Fiyati = 59.99, Platformu = "PC", BarkodNumarasi = "1234567890123", TekPlatform = true },
            new Oyunlar { Id = 2, OyunAdi = "Grand Theft Auto V", Fiyati = 39.99, Platformu = "PlayStation 4", BarkodNumarasi = "9876543210123", TekPlatform = false },
            new Oyunlar { Id = 3, OyunAdi = "The Legend of Zelda: Breath of the Wild", Fiyati = 49.99, Platformu = "Nintendo Switch", BarkodNumarasi = "4567890123456", TekPlatform = true },
            new Oyunlar { Id = 4, OyunAdi = "Red Dead Redemption 2", Fiyati = 44.99, Platformu = "Xbox One", BarkodNumarasi = "7890123456789", TekPlatform = false }
            );

        }


    }
}
