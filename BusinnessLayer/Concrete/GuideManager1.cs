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
    public class GuideManager1 : IGuideService1
    {
        IGuideDal1 _guideDal1;

        public GuideManager1(IGuideDal1 guideDal1)
        {
            _guideDal1 = guideDal1;
        }

        public void TAdd(Guide1 t)
        {
            _guideDal1.Insert(t);
        }

        public void TChangeToFalseByGuide(int id)
        {
            _guideDal1.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideDal1.ChangeToTrueByGuide(id);
        }

        public void TDelete(Guide1 t)
        {
            _guideDal1.Delete(t);
        }

        public Guide1 TGetByID(int id)
        {
            return _guideDal1.GetByID(id);
        }

        public List<Guide1> TGetList()
        {
            return _guideDal1.GetList();
        }

        public void TUpdate(Guide1 t)
        {
            _guideDal1.Update(t);
        }
    }
}
