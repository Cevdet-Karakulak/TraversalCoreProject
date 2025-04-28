using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.EntityFramework.EfDestinationDal1;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal1 : GenericRepository<Destination1>, IDestinationDal1
    {
        public Destination1 GetDestinationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations1.Where(x => x.DestinationID == id).Include(x => x.Guide1).FirstOrDefault();
            }
        }     
            public List<Destination1> GetLast4Destinations()
            {
                using (var context = new Context())
                {
                    var values = context.Destinations1.Take(4).OrderByDescending(x => x.DestinationID).ToList();
                    return values;
                }
            }

        
    }
    }
