using AM.ApplicationCore.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
   public class UnitOfWork:IUnitOfWork
    {
        bool disposevalue;
        Type _typerepository;

        DbContext _context;
        public UnitOfWork(DbContext context,Type typerepository)
        {
            _context = context;
            _typerepository = typerepository;
        }

        public  virtual void Dispose(bool disposing)
        {
           if (!disposevalue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposevalue = true;
            }
        }
        ~UnitOfWork()
        {
            Dispose(disposing:false);
        }
        

        public IGenericRepository<TEntity> repository<TEntity>() where TEntity : class
        {
            return (IGenericRepository<TEntity>)Activator.CreateInstance(_typerepository.MakeGenericType(typeof(TEntity)), _context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
