using KalemYazilim.WebAPI.DataAccessLayer.Configuration;
using KalemYazilim.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace KalemYazilim.WebAPI.DataAccessLayer
{
    public class KalemDb : DbContext
    {
        public KalemDb(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Musteri>? Musteris { get; set; }
        public DbSet<Malzeme>? Malzeme { get; set; }
        public DbSet<SatisFaturasi>? SatisFaturasi { get; set; }
        public DbSet<SatisFaturaSatiri>? SatisFaturaSatiri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MalzemeConfig());
            modelBuilder.ApplyConfiguration(new MusteriConfig());
            modelBuilder.ApplyConfiguration(new SatisFaturasiConfig());
            modelBuilder.ApplyConfiguration(new SatisFaturasiSatiriConfig());
        }
    }
}
