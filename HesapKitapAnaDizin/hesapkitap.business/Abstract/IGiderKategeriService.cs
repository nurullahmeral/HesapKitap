using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface IGiderKategoriService{
        GiderKategori GetById(int id);
        List<GiderKategori> GetAll();
        void Create(GiderKategori t);
        void Update(GiderKategori t);
        void Delete(GiderKategori t);
    }
}