using Exercise_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise_01_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsVip_ReturnsFalse()
        {
            //Arrange
            var flight = new Flight();
            var customer = new Customer();

            customer.IsVip = false;
            //Act
            var result = flight.CanBeCancelledBy(customer);
            //Assert
            Assert.IsFalse(result,"Sorry you cant cancel you're reservation(VIP Error)");

        }
    }
}
