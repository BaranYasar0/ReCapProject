using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
            new Car{Id=1,BrandId=1,ColorId=3,DailyPrice=5,Description="temiz",ModelYear=2022 },
            new Car{Id=2,BrandId=2,ColorId=4,DailyPrice=10,Description="çıtır hasarlı",ModelYear=2021 },
            new Car {Id=3,BrandId=3,ColorId=5,DailyPrice=20,Description="fena degil",ModelYear=2018 },
            new Car {Id=4,BrandId=2,ColorId=5,DailyPrice=29,Description="eh degil",ModelYear=2017 },
            };
        }

        public void Add(Car car)
        {
        _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =_cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
        return _cars;
        }


        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
        }
    }
}
