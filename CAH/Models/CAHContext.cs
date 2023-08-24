using Microsoft.EntityFrameworkCore;

namespace CAH.Models
{
    public class CAHContext : DbContext
    {
        public DbSet<WhiteCards> WhiteCards { get; set; }
        public DbSet<BlackCards> BlackCards { get; set; }

        public CAHContext(DbContextOptions options) : base(options) { }
    }
}