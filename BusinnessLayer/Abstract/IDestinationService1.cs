using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface IDestinationService1 : IGenericService<Destination1>
    {
        public Destination1 TGetDestinationWithGuide(int id);

    }
}
