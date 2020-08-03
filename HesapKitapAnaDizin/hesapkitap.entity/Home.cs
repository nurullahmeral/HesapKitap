using System;
using System.Collections.Generic;

namespace hesapkitap.entity{
    public class Home{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public int GunsonuId { get; set; }
        public string NameGunSonu { get; set; }
        public int YoneticiYetkisiKontrol { get; set; }
        public int GunSonuKategoriId { get; set; }
        public int GunSonuTutarId { get; set; }
        public List<HomeGunSonuTutar> HomeGunSonuTutars { get; set; }
        public List<HomeGunSonuKategori> HomeGunSonuKategoris { get; set; }
        
        

    
    }

    internal class ForeignKeyAttribute : Attribute
    {
        private string v;

        public ForeignKeyAttribute()
        {
        }

        public ForeignKeyAttribute(string v)
        {
            this.v = v;
        }
    }

    internal class KeyAttribute : Attribute
    {
    }
}