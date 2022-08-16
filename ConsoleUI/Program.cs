using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //CarDetailTest();


        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.CarId + " / " + car.DailyPrice + " / " + car.BrandName + " / " + car.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " / " + car.BrandId + " / " + car.ColorId + " / " + car.ModelYear + " / " +
                                  car.DailyPrice + " / " +
                                  car.Description);
            }
        }
    }
}