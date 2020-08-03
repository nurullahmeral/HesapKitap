using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreTransferKalemiRepository:EfCoreGenericRepository<TransferKalemi,HesapKitapContext>,ITransferKalemiRepository{
        
    }

}