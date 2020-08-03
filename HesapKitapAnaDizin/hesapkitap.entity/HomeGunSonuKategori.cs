namespace hesapkitap.entity{
    public class HomeGunSonuKategori{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public int GunSonuId { get; set; }
        public Home Home { get; set; }
        public int GunSonuKategoriId { get; set; }
        public GunSonuKategori GunSonuKategoris { get; set; }
    }

}