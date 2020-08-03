namespace hesapkitap.entity{
    public class UrunKategori{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public string UrunKategoriName { get; set; }
        public int GiderEkleId { get; set; }
        public int GiderKategoriId { get; set; }
        
    }
}