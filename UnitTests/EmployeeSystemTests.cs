using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSystem;

namespace NUnitTest.UnitTests
{
    internal class EmployeeSystemTests
    {
        [Test]
        public void Test_Person_Mohit_Type()
        {
            //Act
            Person Mohit = new Person();
            //Assert
            Assert.IsInstanceOf<Person>(Mohit);
            Assert.That(Mohit, Is.TypeOf(typeof(Person)));
            Assert.That(Mohit,Is.InstanceOf<Person>()); //Understands inheritance heirarchy
        }

        [Test]
        public void Test_Employee_Mohit_Type()
        {
            //Act
            Person Mohit = new Employee();
            //Assert
            Assert.IsInstanceOf<Employee>(Mohit);
            //Assert.That(Mohit, Is.TypeOf(typeof(Person)));
            Assert.That(Mohit, Is.InstanceOf<Employee>()); //Understands inheritance heirarchy
            //Assert.That(Mohit, Is.InstanceOf<Person>());
        }

        [Test]
        public void Test_INda_Mohit_Type()
        {
            //Act
            INda Mohit = new Employee();
            //Assert
            Assert.IsInstanceOf<INda>(Mohit);
            //Assert.That(Mohit, Is.TypeOf(typeof(INda)));
            Assert.That(Mohit, Is.InstanceOf<Employee>()); //Understands inheritance heirarchy
            //.That(Mohit, Is.InstanceOf<Person>());
        }
    }
}
