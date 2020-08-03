using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class TransferEkleManager : ITransferEkleService
    {
        private ITransferEkleRepository _transferEkleRepository;
        public TransferEkleManager(ITransferEkleRepository transferEkleRepository)
        {
            _transferEkleRepository = transferEkleRepository;
        }

        public void Create(TransferEkle t)
        {
            _transferEkleRepository.Create(t);
        }

        public void Delete(TransferEkle t)
        {
            _transferEkleRepository.Delete(t);
        }

        public List<TransferEkle> GetAll()
        {
            return _transferEkleRepository.GetAll();
        }

        public TransferEkle GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TransferEkle t)
        {
            throw new System.NotImplementedException();
        }
    }
}