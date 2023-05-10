using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Intefaces
{
    public interface IUnitOfWork:IDisposable
    {
        public int Save();
        public IGenericRepository<Entity> repository<Entity>() where Entity : class;
        
    }
}
