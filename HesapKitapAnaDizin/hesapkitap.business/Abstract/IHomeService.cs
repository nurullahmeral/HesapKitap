using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface IHomeService{
        Home GetById(int id);
        List<Home> GetAll();
        void Create(Home t);
        void Update(Home t);
        void Delete(Home t);

    }
}