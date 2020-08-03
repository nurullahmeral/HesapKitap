using System.Collections.Generic;

namespace hesapkitap.entity{
    public class TransferKalemi{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 
        public int TransferId { get; set; }
        public string Adı { get; set; }
        
        public List<TransferEkleKalem> TransferEkleKalem { get; set; }
    }
}