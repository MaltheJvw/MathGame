using MathGame.Components.Pages;
using MathGame.Model;
using Microsoft.EntityFrameworkCore;

namespace MathGame.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Scoreboard> Scoreboards { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Scoreboards)  // A Profile has many Scoreboards
                .WithOne(s => s.Profile)      // A Scoreboard is associated with one Profile
                .HasForeignKey(s => s.ProfileId);  // Foreign key in Scoreboard

        }
    }
}
