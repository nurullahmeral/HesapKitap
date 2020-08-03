using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class DegerKisitlaManager : IDegerKisitlaService
    {
        private IDegerKisitlaRepository _degerKisitlaRepository;
        public DegerKisitlaManager(IDegerKisitlaRepository degerKisitlaRepository){
            _degerKisitlaRepository = degerKisitlaRepository;

        }
        public void Create(DegerKisitla t)
        {
            _degerKisitlaRepository.Create(t);
        }

        public void Delete(DegerKisitla t)
        {
            _degerKisitlaRepository.Delete(t);
        }

        public List<DegerKisitla> GetAll()
        {
            return _degerKisitlaRepository.GetAll();
        }

        public DegerKisitla GetById(int id)
        {
            return _degerKisitlaRepository.GetById(id);
        }

        public void Update(DegerKisitla t)
        {
            throw new System.NotImplementedException();
        }
    }
}