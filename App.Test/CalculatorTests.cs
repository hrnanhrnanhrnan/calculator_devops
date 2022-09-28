using App.Commons;
using NUnit.Framework;

namespace App.Test
{
    public class Tests
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
            => _calculator = new Calculator();

        [Test]
        public void Addition_Does_Addition()
            => Assert.AreEqual(2, _calculator.Addition(1, 1));

        [Test]
        public void Addition_Does_Addition_With_Decimals()
            => Assert.AreEqual(3, _calculator.Addition(1.5, 1.5));

        [Test]
        public void Addition_Returns_Double()
        {
            var returnType = _calculator.Addition(1, 1).GetType();
            Assert.AreEqual(typeof(double), returnType);
        }
    }
}