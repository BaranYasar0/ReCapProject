// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");


CarManager carManager = new CarManager(new EfCarDal());
Car car1= new Car() {CarId=31,ColorId=12,BrandId=2,DailyPrice=150,Description="Mercedes",ModelYear=2022 };
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

carManager.Add(car1);
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}
