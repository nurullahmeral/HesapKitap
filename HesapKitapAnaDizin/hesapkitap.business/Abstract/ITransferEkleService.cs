using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface ITransferEkleService
    {
        TransferEkle GetById(int id);
        List<TransferEkle> GetAll();
        void Create(TransferEkle t);
        void Update(TransferEkle t);
        void Delete(TransferEkle t);
        
        
    }
}