using System.Collections.Generic;
using hesapkitap.business.Abstract;
using hesapkitap.data.Abstract;
using hesapkitap.data.Concrete.EfCore;
using hesapkitap.entity;

namespace hesapkitap.business.concrete{
    public class HomeManager : IHomeService
    {
        private IHomeRepository _homerepository;
        public HomeManager(IHomeRepository homerepository)
        {
            _homerepository = homerepository;
        }
        public void Create(Home t)
        {
            //İş kurulları uygulanacak
            _homerepository.Create(t);
        }

        public void Delete(Home t)
        {
            //İş kurulları uygulanacak
           _homerepository.Delete(t);
        }

        public List<Home> GetAll()
        {
            return _homerepository.GetAll();
        }

        public Home GetById(int id)
        {
            return _homerepository.GetById(id);
        }

        public void Update(Home t)
        {
            throw new System.NotImplementedException();
        }
    }

}