using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Domain
{
    [TestFixture]
    public class AddressTest
    {
        [Test]
        public void Validate_AddressWithNoPostcode_GeneratesListOfErrors()
        {
            var address = new Address();
            var result = new AddressValidator().Validate(address);
            Assert.That(result.Errors.Count, Is.EqualTo(1));
        }
    }
}
