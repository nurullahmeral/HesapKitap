using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    
   
    public class GunSonuKategoriManager : IGunSonuKategoriService
    {
        private IGunSonuKategoriRepository _gunSonuKategoriRepository;
        public GunSonuKategoriManager(IGunSonuKategoriRepository gunSonuKategoriRepository){
            _gunSonuKategoriRepository = gunSonuKategoriRepository;

        }
        public void Create(GunSonuKategori t)
        {
            _gunSonuKategoriRepository.Create(t);
        }

        public void Delete(GunSonuKategori t)
        {
            _gunSonuKategoriRepository.Delete(t);
        }

        public List<GunSonuKategori> GetAll()
        {
            return _gunSonuKategoriRepository.GetAll();
        }

        public GunSonuKategori GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(GunSonuKategori t)
        {
            throw new System.NotImplementedException();
        }
    }
}