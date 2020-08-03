using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class GunSonuTutarManager : IGunSonuTutarService
    {
        private IGunSonuTutarRepository _gunSonuTutarRepository;
        public GunSonuTutarManager(IGunSonuTutarRepository gunSonuTutarRepository)
        {
            _gunSonuTutarRepository = gunSonuTutarRepository;
        }
        public void Create(GunSonuTutar t)
        {
            _gunSonuTutarRepository.Create(t);
        }

        public void Delete(GunSonuTutar t)
        {
            _gunSonuTutarRepository.Delete(t);
        }

        public List<GunSonuTutar> GetAll()
        {
            return _gunSonuTutarRepository.GetAll();
        }

        public GunSonuTutar GetById(int id)
        {
            throw new System.NotImplementedException();
            
        }

       
        public List<GunSonuTutar> GetGunSonuByTutars(string name)
        {
            return _gunSonuTutarRepository.GetGunSonuByTutar(name);
        }

        public void Update(GunSonuTutar t)
        {
            throw new System.NotImplementedException();
        }
    }
}