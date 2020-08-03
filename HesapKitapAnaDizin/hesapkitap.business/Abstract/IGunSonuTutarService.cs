using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface IGunSonuTutarService{
        GunSonuTutar GetById(int id);
        List<GunSonuTutar> GetAll();
        List<GunSonuTutar> GetGunSonuByTutars(string name);
        void Create(GunSonuTutar t);
        void Update(GunSonuTutar t);
        void Delete(GunSonuTutar t);

    }
}