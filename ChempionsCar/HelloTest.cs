using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChempionsCar
{
    [TestClass]
    public class HelloTest
    {

        [TestMethod]
        public void TwoIsGreaterThanOne()
        {
            // Arrange
            int number1 = 2;
            int number2 = 1;

            // Act
            bool result = number1 > number2;

            // Assert
            Assert.IsTrue(result);
        }

    }
}
