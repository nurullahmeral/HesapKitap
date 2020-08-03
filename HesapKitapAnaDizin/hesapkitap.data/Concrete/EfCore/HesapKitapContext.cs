using hesapkitap.entity;
using Microsoft.EntityFrameworkCore;

namespace hesapkitap.data.Concrete.EfCore{
    public class HesapKitapContext:DbContext{
        public DbSet<Home> Homes { get; set; }
        public DbSet<GiderEkle> GiderEkles { get; set; }
        public DbSet<GiderKategori> GiderKategoris { get; set; }
        public DbSet<GunSonuTutar> GunSonuTutars { get; set; }
        public DbSet<TransferEkle> TransferEkles { get; set; }
        public DbSet<GunSonuKategori> GunSonuKategoris{get; set; }
        public DbSet<TransferKalemi> TransferKalemis { get; set; }
        public DbSet<UrunKategori> UrunKategoris { get; set; }
        public DbSet<TarihKontrol> TarihKontrols { get; set; }
        public DbSet<DegerKisitla> DegerKisitlas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=hesapkitapDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<HomeGunSonuTutar>()
                .HasKey(c=>new {c.GunSonuId,c.GunSonuTutarId});

        }


        
    }
}