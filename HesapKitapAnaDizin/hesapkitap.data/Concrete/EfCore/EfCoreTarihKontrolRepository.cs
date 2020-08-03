using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreTarihKontrolRepository:EfCoreGenericRepository<TarihKontrol,HesapKitapContext>,ITarihKontrolRepository{
        
    }
}