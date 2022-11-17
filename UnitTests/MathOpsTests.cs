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

        [TestCase(100.2,200.3,300.5)]
        [TestCase(100.2,10.255,110.455)]
        [TestCase(-12.2, 0, -12.2)]
        [TestCase(25.5, -55.5, -30)]
        public void Test_Addition_2_Decimal_Numbers_Positive_Case(decimal n1, decimal n2, decimal expected)
        {
            //Arrange
            
            //Act
            decimal actual = mathOperations.Add(n1, n2);
            //Assert
            Assert.AreEqual(expected, actual);
            //Assert.Greater(n1, 0);
            //Assert.Greater(n2, 0);
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

        [TestCase(100.2, 200.3, -100.1)]
        [TestCase(100.2, 10.255, 89.945)]
        [TestCase(-12.2, 0, -12.2)]
        [TestCase(25.5, -55.5, 81)]
        public void Test_Substraction_2_Decimal_Numbers_Positive_Case(decimal n1,decimal n2,decimal expected)
        {
            //Arrange
        
            //Act
            decimal actual = mathOperations.Substarct(n1, n2);
            //Assert
            Assert.AreEqual(expected, actual);
            //Assert.Greater(n1, 0);
            //Greater(n2, 0);

        }

        [Test]
        public void Test_Substraction_2_Decimal_Numbers_Negative_Case()
        {
            //Arrange
            decimal n1 = 200.3m;
            decimal n2 = -100.2m;
            decimal expected = 100.1m;
            //Act
            decimal actual = mathOperations.Substarct(n1, n2);
            //Assert
            Assert.AreNotEqual(expected, actual);
            Assert.Less(n2, 0);

        }



    }
}
