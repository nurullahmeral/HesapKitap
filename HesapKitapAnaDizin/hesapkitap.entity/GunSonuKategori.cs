using System.Collections.Generic;

namespace hesapkitap.entity{
    public class GunSonuKategori{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public int GunSonuKategoriId { get; set; }
        public string GunSonuKategoriName { get; set; }
        public int GunSonuTutarId { get; set; }
        public int HomeId { get; set; }
        public List<HomeGunSonuKategori> HomeGunSonuKategori { get; set; }

    }
    
}
