using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Validators;
using NUnit.Framework;

namespace WebFormsApp.App_Code
{
    [TestFixture]
    public class FluentJQueryValidation_Tests
    {
        internal class DummyAddress
        {
            public string Postcode { get; set; }
        }

        internal class NotEmptyAddressValidator : AbstractValidator<DummyAddress>
        {
            public NotEmptyAddressValidator()
	        {
                RuleFor(add => add.Postcode).NotEmpty();
	        }
        }

        [Test]
        public void GenerateScript_NotEmptyAddressValidator_GeneratesCorrectScript()
        {
            var dummyAddressValidator = new NotEmptyAddressValidator();
            string actual = new FluentJQueryValidation().GenerateScript(dummyAddressValidator);
            string expectedJs = "";

            Assert.That(actual, Is.EqualTo(expectedJs));
        }
    }
}