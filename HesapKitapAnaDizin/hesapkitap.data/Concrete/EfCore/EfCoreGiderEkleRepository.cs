using System.Collections.Generic;
using System.Linq;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreGiderEkleRepository : EfCoreGenericRepository<GiderEkle, HesapKitapContext>, IGiderEkleRepository
    {
        // public List<GiderEkle> GetAylikGider()
        // {
        //     using(var context = new HesapKitapContext()){
        //         return context.GiderEkles.ToList();

        //     }
        // }
    }
}