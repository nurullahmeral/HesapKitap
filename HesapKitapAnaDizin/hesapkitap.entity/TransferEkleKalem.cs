namespace hesapkitap.entity{
    public class TransferEkleKalem{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public int Tutar { get; set; }
        public TransferEkle TransferEkle { get; set; }
        public string Adı { get; set; }
        public TransferKalemi TransferKalemi { get; set; }


    }
}