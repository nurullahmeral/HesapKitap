using System.Collections.Generic;
using hesapkitap.entity;

namespace hesapkitap.business.Abstract{
    public interface ITransferKalemiService{
        TransferKalemi GetById(int id);
        List<TransferKalemi> GetAll();
        void Create(TransferKalemi t);
        void Update(TransferKalemi t);
        void Delete(TransferKalemi t);

    }
}