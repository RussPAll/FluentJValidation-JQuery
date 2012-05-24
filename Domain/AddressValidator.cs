using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;

namespace Domain
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(add => add.Postcode).NotEmpty();
        }
    }
}
