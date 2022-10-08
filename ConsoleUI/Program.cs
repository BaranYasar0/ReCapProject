// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;

Console.WriteLine("Hello, World!");


CarManager carManager = new CarManager(new EfCarDal());
Car car1= new Car() {CarId=41,ColorId=12,BrandId=2,DailyPrice=150,Description="Mercedes",ModelYear=2022 };
Car car2 = new Car() { CarId = 5, ColorId = 22, BrandId = 1, DailyPrice = 155, Description = "Mercedes", ModelYear = 2022 };
Car car3 = new Car() { CarId = 6, ColorId = 22, BrandId = 2, DailyPrice = 155, Description = "A", ModelYear = 2022 };
Car car4 = new Car() { CarId = 7, ColorId = 22, BrandId = 2, DailyPrice = 0, Description = "ABC", ModelYear = 2022 };

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

carManager.Add(car1);
carManager.Add(car2);
carManager.Add(car3);
carManager.Add(car4);

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}
