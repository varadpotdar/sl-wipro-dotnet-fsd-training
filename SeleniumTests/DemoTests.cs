namespace SeleniumTests
{
    [TestFixture]
    public class DemoTests
    {
        //[OneTimeSetUp]
        //public void OneTimeSetupMethod()
        //{
        //    Console.WriteLine("OneTimeSetupMethod ...");
        //}

        //[OneTimeTearDown]
        //public void OneTimeTearDownMethod()
        //{
        //    Console.WriteLine("OneTimeTearDownMethod ...");
        //    //Console.ReadLine();
        //}

        [SetUp]
        public void TestSetupMethod()
        {
            Console.WriteLine("TestSetupMethod ...");
        }

        [TearDown]
        public void TestTearDownMethod()
        {
            Console.WriteLine("TestTearDownMethod ...");
        }


        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 is executing ...");
            Assert.That(1, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 is executing ...");
            Assert.That(1, Is.EqualTo(1));
        }

        [Test]
        public void Test3()
        {
            Console.WriteLine("Test3 is executing ...");
            Assert.That(1, Is.EqualTo(1));
        }

    }
}
