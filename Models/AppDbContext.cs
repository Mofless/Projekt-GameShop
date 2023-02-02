using Microsoft.EntityFrameworkCore;


namespace Ihor_Projekt_Game.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game> Game { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public DbSet<CollectionGame> CollectionGame { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        /////////////////////////////////////////////////////////////////////
        /////????
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Genre>()
                .HasOne(e => e.Game)
                .WithOne(e => e.Genre)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<Game>()
                .HasOne(e => e.Genre)
                .WithOne(e => e.Game)
                .OnDelete(DeleteBehavior.ClientCascade);
        }


    }
}
