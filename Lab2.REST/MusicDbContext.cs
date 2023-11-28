using Microsoft.EntityFrameworkCore;
using MusicWebAPI.Models;

namespace MusicWebAPI
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }


        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasOne(s => s.Author)
                                       .WithMany(a => a.Songs)
                                       .HasForeignKey(c => c.AuthorId)
                                       .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}