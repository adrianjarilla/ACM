using System;
using ACM_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM_BL_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
