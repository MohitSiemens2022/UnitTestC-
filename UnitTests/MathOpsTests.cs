using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitTest.Source;

namespace NUnitTest.UnitTests
{
    internal class MathOpsTests
    {
        MathOperations mathOperations;

        [SetUp]
        public void Initialise()
        {
            mathOperations = new MathOperations();
        }

        [Test]
        public void Test_Addition_2_Decimal_Numbers_Positive_Case()
        {
            //Arrange
            decimal n1 = 100.2m;
            decimal n2 = 200.3m;
            decimal expected = 300.5m;
            //Act
            decimal actual = mathOperations.Add(n1, n2);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Greater(n1, 0);
            Assert.Greater(n2, 0);

        }

        [Test]
        public void Test_Addition_2_Decimal_Numbers_Negative_Case()
        {
            //Arrange
            decimal n1 = 100.2m;
            decimal n2 = -200.3m;
            decimal expected = 300.5m;
            //Act
            decimal actual = mathOperations.Add(n1, n2);
            //Assert
            Assert.AreNotEqual(expected, actual);
            Assert.Less(n2, 0);

        }



    }
}
