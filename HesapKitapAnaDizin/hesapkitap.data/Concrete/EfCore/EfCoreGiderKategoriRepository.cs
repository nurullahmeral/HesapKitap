using System.Collections.Generic;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreGiderKategoriRepository : EfCoreGenericRepository<GiderKategori,HesapKitapContext>,IGiderKategoriRepository
    {
        
    }
}