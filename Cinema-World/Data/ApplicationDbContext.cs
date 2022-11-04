using Cinema_World.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_CinematographyModel>().HasKey(ac => new
            {
                ac.ActorID,
                ac.CinematographyID
            });
            modelBuilder.Entity<Actor_CinematographyModel>().HasOne(c => c.Cinematography).WithMany(ac => ac.Actors_Cinematography).HasForeignKey(c => c.CinematographyID);
            modelBuilder.Entity<Actor_CinematographyModel>().HasOne(c => c.Actor).WithMany(ac => ac.Actors_Cinematography).HasForeignKey(c => c.ActorID);
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<CinematographyModel> Cinematography { get; set; }
        public DbSet<WriterModel> Writers { get; set; }
        public DbSet<DirectorModel> Directors { get; set; }
        public DbSet<Actor_CinematographyModel> Actor_Cinematographys { get; set; }

    }
}
