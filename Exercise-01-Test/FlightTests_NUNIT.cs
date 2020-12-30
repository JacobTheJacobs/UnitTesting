using Exercise_01;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace Exercise_01_Test
{
    [TestFixture]
    public class FlightTests_NunitTest
    {
        /*
         * 
         * 
         * 
        ///
        /// 1
        //
        [Test]
        public void CanBeCancelledBy_UserIsVip_ReturnsTrue()
        {
            //Arrange
            var flight = new Flight();
            var customer = new Customer { IsVip = true };

            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            //Assert.IsTrue(result, "VIP user failde to cancel the reservation");
            //Assert.That(result,Is.True, "VIP user failde to cancel the reservation");
            Assert.That(result==true, "VIP user failed to cancel the reservation");
        }

        ///
        /// 1
        /// 
        [Test]
        public void CanBeCancelledBy_UserIsNotVip_ReturnsFalse()
        {
            //Arrange
            var flight = new Flight();
            var customer = new Customer { IsVip = false };

            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            //Assert.isFalse(result, "VIP user failde to cancel the reservation");
            //Assert.That(result,Is.False, "VIP user failde to cancel the reservation");
            Assert.That(result == false, "User is not VIP, failed to cancel the reservation");
        }


        /// 
        /// 2
        /// 
        [Test]
        public void CanBeCancelledBy_UserThatMadeOrder_ReturnsTrue()
        {
            //Arrange

            var customer = new Customer();
            var flight = new Flight { OrderBy = customer };


            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            //Assert.IsTrue(result, "Sorry you cant cancel the order that you didnort made");
            //Assert.That(result,Is.True, "Sorry you cant cancel the order that you didnort made");
            Assert.That(result == true, "Sorry you cant cancel the order that you didnort made");

        }

        /// 
        /// 3
        /// 
        [Test]
        public void CanBeCancelledBy_UserThatNotMadeOrderAndNotVip_ReturnsFalse()
        {
            //Arrange

            var customer = new Customer { IsVip = false };
            var flight = new Flight { OrderBy = new Customer() };



            //Act
            var result = flight.CanBeCancelledBy(customer);

            //Assert
            //Assert.isFalse(result, "VIP user failde to cancel the reservation");
            //Assert.That(result,Is.False, "VIP user failde to cancel the reservation");
            Assert.That(result == false, "Sorry this flight was orderd by other user");

        }




        *///-----------------------------------------------------------------------------------
        /// 
        /// 4
        /// 
        [Test]
        public void CanBeOrderedBy_UserThatNot18YearsOld_ReturnsFalse()
        {
            //Arrange

            var customer = new Customer { Age = 17 };
            var flight = new Flight { OrderBy = new Customer() };


            //Act
            var result = flight.CanBeOrderedBy(customer);

            //Assert
            Assert.IsFalse(result);

        }
        /// 
        /// 4 OPTIONAL
        /// 
        [Test]
        public void CanBeOrderedBy_UserThatNot18YearsOldAndCorrectDate_ReturnsTrue()
        {
            //Arrange
            var customer = new Customer { Age = 18 };
            var flight = new Flight { OrderBy = new Customer(), FlightDate = new DateTime(2020, 8, 4) };

            //Act
            var result = flight.CanBeOrderedBy(customer);

            //Assert
            Assert.IsTrue(result);

        }
    }
}
