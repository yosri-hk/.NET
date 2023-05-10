using AM.ApplicationCore.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext _context;
        DbSet<TEntity> _dbset;
        
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            _dbset.RemoveRange(_dbset.Where(where));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbset.AsEnumerable();
        }

        public TEntity GetById(params object[] keyvalues)
        {
            return _dbset.Find(keyvalues);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return _dbset.Where(where).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return _dbset.Where(where).AsEnumerable();
        }

        public void Update(TEntity entity)
        {
            _dbset.Update(entity);
        }

        

       

       

       
    }

}

