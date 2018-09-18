using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        readonly ICalculator _calc = new Calculator();

        double num1 = 5.3;
        double num2 = 3.4;

        [TestMethod]
        public void AddTest()
        {
            
            var result = _calc.Add(num1, num2);

            Assert.AreEqual(8.7, result);

        }

        [TestMethod]
        public void SubtractTest()
        {
            var result = _calc.Subtract(num1, num2);

            Assert.AreEqual(1.9, result);

        }

        [TestMethod]
        public void MultiplyTest()
        {
            double result = _calc.Multiply(num1, num2);

            Assert.AreEqual(18.02, result);
        }

        [TestMethod]
        public void ValidDivideDoubleTest()
        {
            double result = _calc.Divide(num1, num2);

            Assert.AreEqual(1.5588235294117647, result);
        }

        [TestMethod]
        public void InvalidDivideDoubleTest()
        {
            try
            {
                var result = _calc.Divide(num1, 0);
                Assert.Fail();
            }
            catch (System.ArgumentException ex)
            {
                Assert.IsNotNull(ex);
            }
        }

        [TestMethod]
        public void ValidDivideIntTest()
        {
            int int1 = 10;
            int int2 = 5;
            double result = _calc.Divide(int1, int2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void InvalidDivideIntTest()
        {
            int int1 = 10;
            try
            {
                var result = _calc.Divide(int1, 0);
                Assert.Fail();
            }
            catch (System.ArgumentException ex)
            {
                Assert.IsNotNull(ex);
            }
        }

    }
}
