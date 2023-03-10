using Collage.Models;
using Collage.Models.AddressSetting;
using Collage.Models.PrecenceAbcence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Collage.EfCoreContext.ConnectionSetting
{
    public class DBSContext : DbContext
    {
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<PrecenceAbcenceS> PrecenceAbcences { get; set; } 
        public DBSContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactUs>();
            modelBuilder.Entity<City>();
            modelBuilder.Entity<Province>();
            modelBuilder.Entity<Student>();
            modelBuilder.Entity<PrecenceAbcenceS>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
