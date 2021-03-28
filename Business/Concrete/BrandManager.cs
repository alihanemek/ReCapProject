using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> Delete()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(c => c.BrandId == brandId);
        }

        public List<Brand> Insert()
        {
            throw new NotImplementedException();
        }

        public List<Brand> Update()
        {
            throw new NotImplementedException();
        }
    }
}
