using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;



//CarManager carManager = new CarManager(new EfCarDal());

//ColorManager colorManager = new ColorManager(new EfColorDal());
//BrandManager brandManager = new BrandManager(new EfBrandDal());
//Car car1 = new Car() { CarId = 34, ColorId = 1, BrandId = 2, DailyPrice = 120, Description = "Polo", ModelYear = 2022 };
//Color color1 = new Color() { ColorId = 11, ColorName = "Lila" };
//Brand brand1 = new Brand() { BrandId = 2, BrandName = "Opel" };
//carManager.Add(car1);
//colorManager.Add(color1);
//brandManager.Add(brand1);

//CarTest();
//ColorTest();
//randTest();

//carManager.Delete(car1);

//CarDetailTest();
//CustomerTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetAll();
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.CarId);
    }
}

static void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());
    foreach (var item in colorManager.GetAll())
    {
        Console.WriteLine("Color Name: " + item.ColorName);
    }
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    foreach (var item in brandManager.GetAll())
    {
        Console.WriteLine("Brand Name: " + item.BrandName);
    }
}

static void CarDetailTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDetails();
    foreach (var car in result.Data)
    {
        Console.WriteLine(result.Message);
        Console.WriteLine("{0}/ {1} / {2} / {3} ", car.Description, car.BrandName, car.ColorName, car.DailyPrice);
    }
}

static void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    var result = customerManager.GetAll();
    foreach (var customer in result.Data)
    {
        Console.WriteLine("Veritabanı uyarısı: {0} / Şirket Adı: {1}", result.Message, customer.CompanyName);
        //Console.WriteLine("Veritabanı uyarısı: {0} / Şirket Adı: ", customer.);

    }
}