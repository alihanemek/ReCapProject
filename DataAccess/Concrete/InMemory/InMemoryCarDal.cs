using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=800, ModelYear=2010, CarName="BMW", Description="Kiralamaya uygun"},
                new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=3000, ModelYear=2015, CarName="BMW", Description="Kiralamaya uygun"},
                new Car{Id=3, BrandId=2, ColorId=3, DailyPrice=1000, ModelYear=2019, CarName="Mercedes", Description="Kiralamaya uygun değil"},
                new Car{Id=4, BrandId=2, ColorId=1, DailyPrice=8000, ModelYear=2021, CarName="Mercedes", Description="Kiralamaya uygun"},
                new Car{Id=5, BrandId=3, ColorId=1, DailyPrice=5000, ModelYear=2021, CarName="Ford", Description="Kiralamaya uygun değil"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Id = car.Id;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
