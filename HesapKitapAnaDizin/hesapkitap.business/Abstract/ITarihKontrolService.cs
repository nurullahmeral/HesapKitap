using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface ITarihKontrolService{
        TarihKontrol GetById(int id);
        List<TarihKontrol> GetAll();
        void Create(TarihKontrol t);
        void Update(TarihKontrol t);
        void Delete(TarihKontrol t);
    }
}