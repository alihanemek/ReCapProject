using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarFeaturesContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarFeaturesContext context = new CarFeaturesContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.BrandId
                             select new CarDetailDto 
                             {
                                 CarId = p.Id, CarName = p.CarName, 
                                 BrandName = c.BrandName
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
