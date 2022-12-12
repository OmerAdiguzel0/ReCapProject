using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Core.Entities.Concrete;
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
            //UserTest();
            //CustomerTest();
            //RentalTest();
        }

       /* private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 3, CustomerId = 2, RentDate = new DateTime(2021, 12, 12) });
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 5, CompanyName = "İstek" });

            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.CustomerId + " / " + customer.UserId + " / " + customer.CompanyName);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
                { FirstName = "Rojhat", LastName = "İstek", Email = "asdqwueqw@gmail.com", Password = "1234567" });

            var result = userManager.GetAll();

            foreach (var user in result.Data)
            {
                Console.WriteLine(user.UserId + " / " + user.FirstName + " / " + user.LastName + " / " + user.Email + " / " +
                                  user.Password);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.DailyPrice + " / " + car.BrandName + " / " + car.ColorName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.BrandId + " / " + car.ColorId + " / " + car.ModelYear + " / " +
                                      car.DailyPrice + " / " +
                                      car.Description);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
            
        }*/
    }
}