using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSystem;

namespace NUnitTest.UnitTests
{
    internal class SimpleTest
    {
        [Test]
        public void AllItemTests()
        {
            object[] ints = new object[]{ 1, 2,3, 4 };
            object[] doubles = new object[] { 0.99, 2.1, 3.14, 4.05 };
            object[] strings = new object[] { "bad", "cat", "dog","dad","cat" };

            //Classic Syntax
            CollectionAssert.AllItemsAreInstancesOfType(ints,typeof(int));
            CollectionAssert.AllItemsAreNotNull(ints);
            CollectionAssert.AllItemsAreUnique(ints);
            CollectionAssert.AllItemsAreInstancesOfType(strings,typeof(string));

            //Collection Syntax
            Assert.That(ints, Is.All.Not.Null);
            Assert.That(ints, Has.None.Null);
            Assert.That(ints,Is.All.InstanceOf(typeof(int)));
            Assert.That(ints,Has.All.InstanceOf(typeof(int)));
            Assert.That(strings, Is.All.InstanceOf(typeof(string)));
            Assert.That(strings,Has.All.InstanceOf(typeof(string)));
            Assert.That(ints, Is.Unique);


            //New Syntax
            Assert.That(strings, Is.Not.Unique);
            Assert.That(ints,Has.None.Null);
            Assert.That(ints,Has.All.GreaterThan(0));
            //Assert.That(strings, Is.All.Contains("a"));
            Assert.That(strings,Has.Some.StartsWith("ba"));
            Assert.That(doubles, Has.Some.EqualTo(1).Within(0.5));

        }
    }
}
