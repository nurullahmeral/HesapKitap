using System.Collections.Generic;
using System.Linq;
using hesapkitap.data.Abstract;
using hesapkitap.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreGunSonuTutarRepository : EfCoreGenericRepository<GunSonuTutar, HesapKitapContext>, IGunSonuTutarRepository
    {
      

        List<GunSonuTutar> IGunSonuTutarRepository.GetGunSonuByTutar(string name)
        {
             using (var context = new HesapKitapContext()){
                var gunSonuTutar = context.GunSonuTutars.AsQueryable();
                if(!string.IsNullOrEmpty(name)){
                    gunSonuTutar = gunSonuTutar
                                            .Where(i=>i.Tarih == name);
                    
                                            
                                            
                                            
                                            
                                            

                }
                return gunSonuTutar.ToList();
            }
        }
    }
}