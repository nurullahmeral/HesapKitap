using System.Linq;
using hesapkitap.entity;
using Microsoft.EntityFrameworkCore;

namespace hesapkitap.data.Concrete.EfCore{
    public static class SeedDatabase{
        public static void Seed(){
            var context = new HesapKitapContext();
            if(context.Database.GetPendingMigrations().Count()==0){
                if(context.Homes.Count()==0){
                    context.Homes.AddRange(Homes);
                }
                if(context.GunSonuTutars.Count()==0){
                    context.GunSonuTutars.AddRange(GunSonuTutars);
                }
                if(context.GunSonuKategoris.Count()==0){
                    context.GunSonuKategoris.AddRange(GunSonuKategoris);
                }
            }
            context.SaveChanges();
            
        }
        private static Home[] Homes={
            new Home(){NameGunSonu="Kredi Kartı"},
            new Home(){NameGunSonu="Set Kart"},
            new Home(){NameGunSonu="Yemek Çeki"},
        };

        private static GunSonuTutar[] GunSonuTutars={
            new GunSonuTutar(){NameGunSonu="Kredi Kartı",Tutar=1000,Tarih="28.05.1996"},
            new GunSonuTutar(){NameGunSonu="Set Kart",Tutar=1500,Tarih="28.05.1996"},
            new GunSonuTutar(){NameGunSonu="Yemek Çeki",Tutar=2000,Tarih="28.05.1996"},
            new GunSonuTutar(){NameGunSonu="Kredi Kartı",Tutar=1000,Tarih="28.05.1996"},
            new GunSonuTutar(){NameGunSonu="Set Kart",Tutar=1500,Tarih="28.05.1996"},
            new GunSonuTutar(){NameGunSonu="Yemek Çeki",Tutar=2000,Tarih="28.05.1996"},
        };

        private static GunSonuKategori[] GunSonuKategoris={
            new GunSonuKategori(){GunSonuKategoriName="Yemek Çekleri"},
            new GunSonuKategori(){GunSonuKategoriName="A Çekleri"},
            new GunSonuKategori(){GunSonuKategoriName="B Çekleri"},
        };
    }
}