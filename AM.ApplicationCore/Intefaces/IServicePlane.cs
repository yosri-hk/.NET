using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Intefaces
{
    public interface IServicePlane:IServices<Plane>
    {
        public void Add(Plane plane);
        public IEnumerable<Plane> GetAll();
        public void Update(Plane plane);
        public void Remove (Plane plane);

    }
}
