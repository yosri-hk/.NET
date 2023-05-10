using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Plane = AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>,IServicePlane

    {
        IUnitOfWork _unitOfWork;    
        IGenericRepository<Plane> _genericRepository;
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._unitOfWork=unitOfWork;
        }
        //public ServicePlane(IGenericRepository<Plane> genericRepository)
        //{
        //    _genericRepository = genericRepository;
        //}

        public void Add(Plane plane)
        {
            _unitOfWork.repository<Plane>().Add(plane);
        }

        

        public IEnumerable<Plane> GetAll()
        {
            return _unitOfWork.repository<Plane>().GetAll();
        }

        public void Remove(Plane plane)
        {
            _unitOfWork.repository<Plane>().Delete(plane);
        }

      

       

        public void Update(Plane plane)
        {
            _unitOfWork.repository<Plane>().Update(plane);
        }

       
    }
}
