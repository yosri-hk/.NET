using AM.ApplicationCore.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class Service<TEntity> : IServices<TEntity> where TEntity : class
    {
        IUnitOfWork _unitofwork;
        IGenericRepository<TEntity> _repository;
        public Service(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
            _repository = unitofwork.repository<TEntity>();
        }
        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            _repository.Delete(where);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return _repository.Get(where);
        }



        public TEntity GetById(params object[] keyvalues)
        {
            return _repository.GetById(keyvalues);
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return _repository.GetMany(where);
        }

        public void SubmitChanges()
        {
            _unitofwork.Save();
        }


        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();

        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

    }
}
