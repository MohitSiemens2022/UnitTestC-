namespace NUnitTest.UnitTests
{
    public class Tests
    {
        [OneTimeSetUp]
        public void Initialise()
        {

        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Assert.Pass("Assuiming pass is already tested before in previous phase");
            Assert.IsTrue(true);
        }
    }
}