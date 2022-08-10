using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
