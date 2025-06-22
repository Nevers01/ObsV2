using Microsoft.EntityFrameworkCore;
using Obs.Core.Models;

namespace Obs.Core.Helper
{
    public class ObsDbContext : DbContext
    {
        public ObsDbContext()
        {
        }

        public ObsDbContext(DbContextOptions<ObsDbContext> contextOptions) : base(contextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Buraya kendi bağlantı cümleni yaz
                optionsBuilder.UseSqlServer("YOUR_CONNECTION_STRING_HERE");
            }
        }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Authority> Authoritys { get; set; }
        public DbSet<Discontinuity> Discontinuitys { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
