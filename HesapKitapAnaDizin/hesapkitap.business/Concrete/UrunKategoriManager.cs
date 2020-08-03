using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class UrunKategoriManager : IUrunKategoriService
    {
        private IUrunKategoriRepository _urunKategoriRepository;
        public UrunKategoriManager(IUrunKategoriRepository urunKategoriRepository)
        {
            _urunKategoriRepository = urunKategoriRepository;
            
        }
        public void Create(UrunKategori t)
        {
            _urunKategoriRepository.Create(t);
        }

        public void Delete(UrunKategori t)
        {
            _urunKategoriRepository.Delete(t);
        }

        public List<UrunKategori> GetAll()
        {
            return _urunKategoriRepository.GetAll();
        }

        public UrunKategori GetById(int id)
        {
            return _urunKategoriRepository.GetById(id);
        }

        public void Update(UrunKategori t)
        {
            throw new System.NotImplementedException();
        }
    }
}