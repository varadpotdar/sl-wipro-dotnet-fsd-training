namespace UnitTestDemo
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddTest()
        {
            // Arrange
            var a = 101;
            var b = 25;
            var expected = 126;
            
            // Act
            var sum = Calculator.Add(a, b);
            
            // Assert
            //Assert.AreEqual(expected, sum);

            Assert.That(sum, Is.EqualTo(expected));
        }

        [Test]
        public void AllOperationsTest()
        {
            Assert.AreEqual(18, Calculator.Add(23, -5));
            Assert.AreEqual(28, Calculator.Subtract(23, -5));
            Assert.AreEqual(-115, Calculator.Multiply(23, -5));
            Assert.AreEqual(-4, Calculator.Divide(23, -5));
        }

        [Test]
        [Ignore("Fix later")]
        public void SampleFailingTest()
        {
            Assert.AreEqual(-5, Calculator.Divide(23, -5));
        }

        [Test]
        public void MultiplyTest()
        {
            Assert.AreEqual(-115, Calculator.Multiply(23, -5));
            Assert.AreEqual(25, Calculator.Multiply(-5, -5));
            Assert.AreEqual(0, Calculator.Multiply(23, 0));
            Assert.AreEqual(0, Calculator.Multiply(0, 0));
            Assert.AreEqual(Int32.MaxValue, Calculator.Multiply(Int32.MaxValue, 1));
        }

        [Test]
        [TestCase(-115, 23, -5)]
        [TestCase(25, -5, -5)]
        [TestCase(0, 23, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(Int32.MaxValue, Int32.MaxValue, 1)]
        public void MultiplyTest2(int expected, int n1, int n2)
        {
            Assert.AreEqual(expected, Calculator.Multiply(n1, n2));
        }

        [TestCaseSource(nameof(MulCases))]
        public void MultiplyTest3(int expected, int n1, int n2)
        {
            Assert.AreEqual(expected, Calculator.Multiply(n1, n2));
        }

        static object[] MulCases =
        {
            new object[] { -115, 23, -5 },
            new object[] { 25, -5, -5 },
            new object[] { 0, 23, 0 },
            new object[] { 0, 0, 0 },
            new object[] { Int32.MaxValue, Int32.MaxValue, 1 }
        };

        [Test]
        [TestCase(23, -5, ExpectedResult = -115)]
        [TestCase(-5, -5, ExpectedResult = 25)]
        [TestCase(23, 0, ExpectedResult = 0)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(Int32.MaxValue, 1, ExpectedResult = Int32.MaxValue)]
        public int MultiplyTest4(int n1, int n2)
        {
            return Calculator.Multiply(n1, n2);
        }

        [TestCaseSource(nameof(MulCasesFromFile))]
        public int MultiplyTest5(int n1, int n2)
        {
            return Calculator.Multiply(n1, n2);
        }

        public static List<TestCaseData> MulCasesFromFile
        {
            get
            {
                var testCases = new List<TestCaseData>();

                using (var fs = File.OpenRead("C:\\Training\\MulCases.txt"))
                using (var sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] split = line.Split(new char[] { ',' },
                                StringSplitOptions.None);

                            int answer = Convert.ToInt32(split[0]);
                            int a = Convert.ToInt32(split[1]);
                            int b = Convert.ToInt32(split[2]);

                            var testCase = new TestCaseData(a, b).Returns(answer);
                            testCases.Add(testCase);
                        }
                    }
                }

                return testCases;
            }
        }

        [Test]
        [Category("DivideByZero")]
        public void DivideByZeroTest1()
        {
            Assert.Throws(typeof(DivideByZeroException), () => Calculator.Divide(23, 0));
        }

        [Test]
        [Category("DivideByZero")]
        [Description("Test to verify DivideByZero scenarios")]
        [Author("Wipro")]
        public void DivideByZeroTest1B()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(23, 0));
        }

        [TestCase(23, 0, typeof(DivideByZeroException))]
        [Category("DivideByZero")]
        public void DivideByZeroTest2(int n1, int n2, Type expectedException)
        {
            Assert.Throws(expectedException, () => Calculator.Divide(n1, n2));
        }

        [TestCase(23, 0, ExpectedResult = typeof(DivideByZeroException))]
        [Category("DivideByZero")]
        public Type DivideByZeroTest3(int n1, int n2)
        {
            return Assert.Catch(() => Calculator.Divide(n1, n2)).GetType();
        }
    }
}
