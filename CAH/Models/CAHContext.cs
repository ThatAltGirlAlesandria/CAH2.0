using Microsoft.EntityFrameworkCore;

namespace CAH.Models
{
    public class CAHContext : DbContext
    {
        public DbSet<WhiteCards> WhiteCards { get; set; }
        public DbSet<BlackCards> BlackCards { get; set; }
        // public DbSet<Player> Players { get; set; }
        // public DbSet<Hand> Hands { get; set; }
        // public DbSet<PlayerHand> PlayerHands { get; set; }
        // public DbSet<Deck> Decks { get; set; }

        public CAHContext(DbContextOptions options) : base(options) { }
    }
}