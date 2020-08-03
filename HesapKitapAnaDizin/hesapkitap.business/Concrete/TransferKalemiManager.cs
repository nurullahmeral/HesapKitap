using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class TransferKalemiManager : ITransferKalemiService
    {
        private ITransferKalemiRepository _transferKalemiRepository;
        public TransferKalemiManager(ITransferKalemiRepository transferKalemiRepository)
        {
            _transferKalemiRepository = transferKalemiRepository;
        }
        public void Create(TransferKalemi t)
        {
            _transferKalemiRepository.Create(t);
        }

        public void Delete(TransferKalemi t)
        {
            _transferKalemiRepository.Delete(t);
        }

        public List<TransferKalemi> GetAll()
        {
            return _transferKalemiRepository.GetAll();
        }

        public TransferKalemi GetById(int id)
        {
            return _transferKalemiRepository.GetById(id);
        }

        public void Update(TransferKalemi t)
        {
            throw new System.NotImplementedException();
        }
    }
}