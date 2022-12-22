using Microsoft.EntityFrameworkCore;


namespace Ihor_Projekt_Game.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game> Game { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}
