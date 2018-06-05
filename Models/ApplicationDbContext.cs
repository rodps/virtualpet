using Microsoft.EntityFrameworkCore;

namespace Tamagotchi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./tamagotchi.db");
        }
    }
}