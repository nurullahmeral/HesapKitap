namespace hesapkitap.entity{
    public class TarihKontrol{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public string TarihString { get; set; }
        public int TarihGun { get; set; }
        public int TarihAy { get; set; }
        public int TarihYıl { get; set; }
        public int GiderEkleId { get; set; }
        public int GiderKategoriId { get; set; }
        public int GunSonuKategoriId { get; set; }
        public int GunSonuTutarId { get; set; }
        public int HomeId { get; set; }
        public int TransferEkleId { get; set; }
        public int TransferKalemiId { get; set; }
        public int UrunKategoriId { get; set; }

    }
}