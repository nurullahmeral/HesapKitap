using System.Collections.Generic;

namespace hesapkitap.entity{
    public class TransferEkle{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public string TransferTarihi { get; set; }
        public string TransferNereden { get; set; }
        public string TransferNereye { get; set; }
        public double TransferTutari { get; set; }
        public string TransferAciklama { get; set; }
        public int TransferId { get; set; }
        public int TransferKalemiId { get; set; }
        public List<TransferEkleKalem> TransferEkleKalem { get; set; }

    }

}