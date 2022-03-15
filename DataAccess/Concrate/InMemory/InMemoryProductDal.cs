using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _car;
            public InMemoryProductDal()
        {
            _car = new List<Car>
            {
                new Car{ Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2017", DailyPrice = 120000, Description = "Mercedes AMG" },
                new Car{ Id = 2, BrandId = 3, ColorId = 3, ModelYear = "2010", DailyPrice = 65000, Description = "Renault Kangoo"},
                new Car{ Id = 3, BrandId = 5, ColorId = 2, ModelYear = "2012", DailyPrice = 173000, Description = "Bmw 318"},
                new Car{ Id = 4, BrandId = 2, ColorId = 3, ModelYear = "2007", DailyPrice = 60000, Description = "Fiat Fiorino"},
                new Car{ Id = 5, BrandId = 6, ColorId = 1, ModelYear = "2018", DailyPrice = 178000, Description = "Honda Civic"},
                new Car{ Id = 6, BrandId = 4, ColorId = 2, ModelYear = "2008", DailyPrice = 53000, Description = "Toyota Auris"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
