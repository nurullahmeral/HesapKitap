using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class GiderEkleManager : IGiderEkleService
    {
        private IGiderEkleRepository _giderEkleRepository;
        public GiderEkleManager(IGiderEkleRepository giderEkleRepository)
        {
            _giderEkleRepository = giderEkleRepository;
        }
        public void Create(GiderEkle t)
        {
            _giderEkleRepository.Create(t);
        }

        public void Delete(GiderEkle t)
        {
            _giderEkleRepository.Delete(t);
        }

        public List<GiderEkle> GetAll()
        {
           return _giderEkleRepository.GetAll();
        }

        public GiderEkle GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(GiderEkle t)
        {
            throw new System.NotImplementedException();
        }
    }
}