namespace hesapkitap.entity{
    public class DegerKisitla{
        [Key] 
        public int Id { get; set; } 

        public int UserId {get; set;}
        [ForeignKey("UserId")] 

        public string DegerAdi { get; set; }

    }
}