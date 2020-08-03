namespace hesapkitap.entity{
    public class GiderKategori{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public string GiderKategoriler { get; set; }
        public int GiderKategoriId { get; set; }
        public int GiderEkleId { get; set; }
        public int UrunKategoriId { get; set; }
    }

}