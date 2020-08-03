using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface IUrunKategoriService{
        UrunKategori GetById(int id);
        List<UrunKategori> GetAll();
        void Create(UrunKategori t);
        void Update(UrunKategori t);
        void Delete(UrunKategori t);

    }
}