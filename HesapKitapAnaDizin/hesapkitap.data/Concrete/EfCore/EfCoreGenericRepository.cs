using System.Collections.Generic;
using System.Linq;
using hesapkitap.data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace hesapkitap.data.Concrete.EfCore{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        public void Create(TEntity t)
        {
            using(var context = new TContext()){
                context.Set<TEntity>().Add(t);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity t)
        {
            using(var context = new TContext()){
                context.Set<TEntity>().Remove(t);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using(var context = new TContext()){
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using(var context = new TContext()){
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity t)
        {
            using(var context = new TContext()){
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }

}