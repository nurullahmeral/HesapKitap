using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class TarihKontrolManager : ITarihKontrolService
    {
        private ITarihKontrolRepository _tarihKontrolRepository;
        public TarihKontrolManager(ITarihKontrolRepository tarihKontrolRepository)
        {
            _tarihKontrolRepository = tarihKontrolRepository;
        }
        public void Create(TarihKontrol t)
        {
            _tarihKontrolRepository.Create(t);
        }

        public void Delete(TarihKontrol t)
        {
            _tarihKontrolRepository.Delete(t);
        }

        public List<TarihKontrol> GetAll()
        {
            return _tarihKontrolRepository.GetAll();
        }

        public TarihKontrol GetById(int id)
        {
            return _tarihKontrolRepository.GetById(id);
        }

        public void Update(TarihKontrol t)
        {
            throw new System.NotImplementedException();
        }
    }
}