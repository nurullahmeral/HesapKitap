using hesapkitap.entity;
using hesapkitap.data.Abstract;
using System.Collections.Generic;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreHomeRepository:EfCoreGenericRepository<Home,HesapKitapContext>,IHomeRepository
    {
        
    }

}