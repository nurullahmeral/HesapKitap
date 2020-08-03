using System.Collections.Generic;

namespace hesapkitap.entity{
    public class GunSonuTutar{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        
        public double Tutar { get; set; }
        public string Tarih { get; set; }
        public int GunsonuTutarId { get; set; }
        public string Aciklama { get; set; }
        public double result{get; set;}
        public string NameGunSonu { get; set; }
        public int GunSonuKategoriId { get; set; }
        public int HomeId { get; set; }
        public int OnKasaKontrol{ get; set; }
        public int OnKasaTutar { get; set; }
        public List<HomeGunSonuTutar> HomeGunSonuTutars{ get; set; }
    }

}