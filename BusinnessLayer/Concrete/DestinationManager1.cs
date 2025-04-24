using BusinnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class DestinationManager1 : IDestinationService1
    {
        IDestinationDal1 _destinationDal1;

        public DestinationManager1(IDestinationDal1 destinationDal1)
        {
            _destinationDal1 = destinationDal1;
        }

        public void TAdd(Destination1 t)
        {
            _destinationDal1.Insert(t);
        }

        public void TDelete(Destination1 t)
        {
            _destinationDal1.Delete(t);
        }

        public Destination1 TGetByID(int id)
        {
            return _destinationDal1.GetByID(id);
        }

        public Destination1 TGetDestinationWithGuide(int id)
        {
            return _destinationDal1.GetDestinationWithGuide(id);
        }

        //public List<Destination> TGetLast4Destinations()
        //{
        //    return _destinationDal.GetLast4Destinations();
        //}

        public List<Destination1> TGetList()
        {
            return _destinationDal1.GetList();
        }

        public void TUpdate(Destination1 t)
        {
            _destinationDal1.Update(t);
        }
    }
}
