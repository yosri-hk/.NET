using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Intefaces
{
    public interface IServices<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(params object[] keyvalues);

        T Get(Expression<Func<T, bool>> where);
        void Delete(Expression<Func<T, bool>> where);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        void SubmitChanges();
    }
}
