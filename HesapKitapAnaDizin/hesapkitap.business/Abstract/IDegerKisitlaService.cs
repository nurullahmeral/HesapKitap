using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface IDegerKisitlaService
    {
        DegerKisitla GetById(int id);
        List<DegerKisitla> GetAll();
        void Create(DegerKisitla t);
        void Update(DegerKisitla t);
        void Delete(DegerKisitla t);
    }
}