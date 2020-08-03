using System.Collections.Generic;

namespace hesapkitap.data.Abstract{
    public interface IRepository<T>
    {
        
        T GetById(int id);
        List<T> GetAll();
        void Create(T t);
        void Update(T t);
        void Delete(T t);
        
        
        
    }
}