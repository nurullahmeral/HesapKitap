using System.Collections.Generic;
using System.Linq;
using hesapkitap.entity;

public class HomeViewModels{
    // public List<Category> Categories { get; set; }

    public List<Home> GunSonu { get; set; }
    public List<Home> GunSonuCategories { get; set; }
    public List<GunSonuTutar> GunSonuTutars { get; set; }
    public List<TransferEkle> TransferEkles { get; set; }
    public List<GiderEkle> GiderEkles { get; set; }
    public List<GiderKategori> GiderKategoris { get; set; }
    public List<GunSonuKategori> GunSonuKategoris { get; set; }
    public List<UrunKategori> UrunKategoris { get; set; }
    public List<TransferKalemi> TransferKalemis { get; set; }
    public string TarihKisit { get; set; }
    public List<DegerKisitla> DegerKisitlas { get; set; }
    
    // public double TotalPrice(){
    //     var toplam = 0;
        
    //     return toplam;
    // }
}