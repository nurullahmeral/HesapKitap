using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class GiderKategoriManager : IGiderKategoriService
    {
        private IGiderKategoriRepository _giderKategoriRepository;
        public GiderKategoriManager(IGiderKategoriRepository giderKategoriRepository)
        {
            _giderKategoriRepository = giderKategoriRepository;
        }
        public void Create(GiderKategori t)
        {
            _giderKategoriRepository.Create(t);
        }

        public void Delete(GiderKategori t)
        {
            _giderKategoriRepository.Delete(t);
        }

        public List<GiderKategori> GetAll()
        {
            return _giderKategoriRepository.GetAll();
        }

        public GiderKategori GetById(int id)
        {
            return _giderKategoriRepository.GetById(id);
        }

        public void Update(GiderKategori t)
        {
            throw new System.NotImplementedException();
        }
    }
}