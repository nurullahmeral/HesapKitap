using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreUrunKategoriRepository:EfCoreGenericRepository<UrunKategori,HesapKitapContext>,IUrunKategoriRepository{
        
    }
}