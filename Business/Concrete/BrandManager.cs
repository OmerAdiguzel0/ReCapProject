using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;
        IColorService _colorService;

        public BrandManager(IBrandDal brandDal, IColorService colorService)
        {
            _brandDal = brandDal;
            _colorService = colorService;
        }


        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId));
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            IResult result = BusinessRules.Run(ChecIfBrandNameExists(brand.BrandName), CheckIfColorLimitExceded());
            if (result != null)
            {
                return result;
            }

            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(Brand brand)
        {
            IResult result = BusinessRules.Run(ChecIfBrandNameExists(brand.BrandName), CheckIfColorLimitExceded());
            if (result !=null)
            {
                return result;
            }

            _brandDal.Update(brand);
            return new SuccessResult();
        }

        private IResult ChecIfBrandNameExists(string brandName)
        {
            var result = _brandDal.GetAll(b=>b.BrandName== brandName).Any();
            if (result)
            {
                return new ErrorResult(Messages.BrandNameAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckIfColorLimitExceded()
        {
            var result = _colorService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.ColorLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
