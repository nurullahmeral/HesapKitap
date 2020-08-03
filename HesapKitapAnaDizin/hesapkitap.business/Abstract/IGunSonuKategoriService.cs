using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface IGunSonuKategoriService{
        GunSonuKategori GetById(int id);
        List<GunSonuKategori> GetAll();
        void Create(GunSonuKategori t);
        void Update(GunSonuKategori t);
        void Delete(GunSonuKategori t);

    }
}