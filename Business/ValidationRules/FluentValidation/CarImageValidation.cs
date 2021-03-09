﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidation : AbstractValidator<CarImage>
    {
        public CarImageValidation()
        {
            RuleFor(i => i.CarId).NotEmpty();
            RuleFor(i => i.Date).Null();
        }
    }
}
