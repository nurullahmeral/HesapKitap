using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface IGiderEkleService{
        GiderEkle GetById(int id);
        List<GiderEkle> GetAll();
        void Create(GiderEkle t);
        void Update(GiderEkle t);
        void Delete(GiderEkle t);

    }
}