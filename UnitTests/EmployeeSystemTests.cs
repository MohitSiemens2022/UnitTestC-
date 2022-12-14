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
            Assert.That(Mohit, Is.InstanceOf<Person>());
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
            Assert.That(Mohit, Is.InstanceOf<INda>());
        }

        [Test]
        public void Test_Add_Person_With_Valid_Inputs()
        {
            //Arrange
            string name = "Meeena";
            int age = 25;
            string gender = "Female";
            string email = "meena@gmail.com";
            string address = "Pune";

            //Act
            Person.Add(new Person() { Name = name, Age = age, Email = email, Gender = gender, Address = address });

            //Assert
            Assert.That(Person.People.Count, Is.EqualTo(1));
            Assert.That(Person.People, Has.Some.Property("Name").Contains(name));

        }


        [TestCaseSource(typeof(EmpSystemInputs),"ValidPersons")]
        public void TestCaseSource_Add_Person_With_Valid_Inputs(string name,
            int age,string email,string gender,string address)
        {
         
            //Act
            Person.Add(new Person() { Name = name, Age = age, Email = email, Gender = gender, Address = address });

            //Assert
            Assert.That(Person.People.Count, Is.GreaterThan(0));
            Assert.That(Person.People, Has.Some.Property("Name").Contains(name));

        }
    }
}
