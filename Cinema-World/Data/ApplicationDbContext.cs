using Cinema_World.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
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

            modelBuilder.Entity<CinematographyCategory_CinematographyModel>().HasKey(cc => new
            {
                cc.CinematographyCategoryID,
                cc.CinematographyID
            });
            modelBuilder.Entity<CinematographyCategory_CinematographyModel>().HasOne(c => c.Cinematography).WithMany(cc => cc.CinematographyCategories_Cinematography).HasForeignKey(c => c.CinematographyID);
            modelBuilder.Entity<CinematographyCategory_CinematographyModel>().HasOne(c => c.Category).WithMany(cc => cc.CinematographyCategories_Cinematography).HasForeignKey(c => c.CinematographyCategoryID);

            modelBuilder.Entity<Writer_CinematographyModel>().HasKey(wc => new
            {
                wc.WriterID,
                wc.CinematographyID
            });
            modelBuilder.Entity<Writer_CinematographyModel>().HasOne(c => c.Cinematography).WithMany(cc => cc.Writers_Cinematography).HasForeignKey(c => c.CinematographyID);
            modelBuilder.Entity<Writer_CinematographyModel>().HasOne(c => c.Writer).WithMany(cc => cc.Writers_Cinematography).HasForeignKey(c => c.WriterID);

            modelBuilder.Entity<ApplicationUser_CinematographyModel>().HasKey(auc => new
            {
                auc.UserID,
                auc.CinematographyID
            });
            modelBuilder.Entity<ApplicationUser_CinematographyModel>().HasOne(c => c.Cinematography).WithMany(cc => cc.ApplicationUser_Cinematography).HasForeignKey(c => c.CinematographyID);
            modelBuilder.Entity<ApplicationUser_CinematographyModel>().HasOne(c => c.User).WithMany(cc => cc.ApplicationUser_Cinematography).HasForeignKey(c => c.UserID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<CinematographyModel> Cinematography { get; set; }
        public DbSet<WriterModel> Writers { get; set; }
        public DbSet<DirectorModel> Directors { get; set; }
        public DbSet<CinematographyGenreModel> CinematographyGenres { get; set; }
        public DbSet<CinematographyCategoryModel> CinematographyCategories { get; set; }
        public DbSet<Actor_CinematographyModel> Actors_Cinematography { get; set; }
        public DbSet<CinematographyCategory_CinematographyModel> CinematographyCategories_Cinematography { get; set; }
        public DbSet<Writer_CinematographyModel> Writers_Cinematography { get; set; }
        public DbSet<ApplicationUser_CinematographyModel> AspNetUserCinematography { get; set; }

    }
}
