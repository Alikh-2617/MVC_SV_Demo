using DAL.DataCantext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenericService<TEntity> where TEntity : class
    {
        //private ApplicationDbContext _context;
        //private DbSet<TEntity> _dbSet;

        //public GenericService(ApplicationDbContext context)
        //{
        //    _context = context; 
        //    _dbSet = context.Set<TEntity>();    
        //}

        //public virtual IEnumerable<TEntity> GetAllEntity()
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual TEntity GetById(int id)
        //    => _dbSet.Find(id);

        //public void InsertEntity(TEntity entity)
        //    =>_dbSet.Add(entity);

        //public virtual void UpdateEntity(TEntity entity)
        //{
        //    _dbSet.Attach(entity);
        //    _context.Entry(entity).State = EntityState.Modified;    
        //}
        ////public virtual void DeleteEntity(int id)
        ////    =>  _dbSet.Remove(_dbSet.Find(id));
        //public virtual void Delete(TEntity entity)
        //{
        //    if (_context.Entry(entity).State == EntityState.Detached)
        //    {
        //        _dbSet.Attach(entity);
        //    }
        //    _dbSet.Remove(entity);
        //}
        //public virtual void Save()
        //{
        //    throw new NotImplementedException();
        //}

        //public object GetById<T>(int v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
