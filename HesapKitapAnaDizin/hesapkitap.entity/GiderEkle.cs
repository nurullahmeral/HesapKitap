namespace hesapkitap.entity{
    public class GiderEkle{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public string UrunAdı { get; set; }
        public string UrunKategorisi { get; set; }
        public string AitOlduguDonem { get; set; }
        public string Tutar { get; set; }
        public string OdemeKontrol { get; set; }
        public string OdemeTuru { get; set; }
        public string VadeTarihi { get; set; }
        public int GiderId { get; set; }
        public int GiderKategoriId { get; set; }
        public int OnKasaKontrol{ get; set; }
        public int OnKasaTutar { get; set; }
        public int OdemeTuruId { get; set; }
    }
}