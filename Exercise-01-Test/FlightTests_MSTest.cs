using Exercise_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise_01_Test
{
    [TestClass]
    public class FlightTests_MSTest
    {
        /// 
        /// 1
        /// 
        [TestMethod]
        public void CanBeCancelledBy_UserIsVip_ReturnsTrue()
        {
            //Arrange
            var flight = new Flight();
            var customer = new Customer { IsVip = true };

            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            Assert.IsTrue(result);
        }

        ///
        /// 1
        /// 
        [TestMethod]
        public void CanBeCancelledBy_UserIsNotVip_ReturnsFalse()
        {
            //Arrange
            var flight = new Flight();
            var customer = new Customer { IsVip = false };

            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            Assert.IsFalse(result);
        }


        /// 
        /// 2
        /// 
        [TestMethod]
        public void CanBeCancelledBy_UserThatMadeOrder_ReturnsTrue()
        {
            //Arrange

            var customer = new Customer();
            var flight = new Flight { OrderBy = customer };


            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            Assert.IsTrue(result);

        }

        /// 
        /// 3
        /// 
        [TestMethod]
        public void CanBeCancelledBy_UserThatNotMadeOrderAndNotVip_ReturnsFalse()
        {
            //Arrange

            var customer = new Customer { IsVip = false };
            var flight = new Flight { OrderBy = new Customer() };



            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
