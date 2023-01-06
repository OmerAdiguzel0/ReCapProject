using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.ModelYear).LessThanOrEqualTo(DateTime.Now.Year).WithMessage("Arabanın Model Yılı İçinde Bulunduğumuz Yıldan Küçük Olmalıdır!");
            //RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(200).When(c => c.ModelYear == 2023);
            //RuleFor(c => c.Description).Must(StartWithA).WithMessage("Araba Açıklaması A Harfi İle Başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");           
        }
    }
}
