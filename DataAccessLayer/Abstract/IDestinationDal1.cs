using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal1 : IGenericDal<Destination1>
    {
        public Destination1 GetDestinationWithGuide(int id);
        //public List<Destination> GetLast4Destinations();
    }
}
