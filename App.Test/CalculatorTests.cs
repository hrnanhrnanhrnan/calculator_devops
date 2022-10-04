using App.Commons;
using NUnit.Framework;

namespace App.Test
{
    public class Tests
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
            => _calculator = new Calculator(); // Arrange

        // Addition
        [Test]
        public void Addition_Does_Addition()
        {
            // Act
            var result = _calculator.Addition(1, 1);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Addition_Does_Addition_With_Decimals()
        {
            // Act
            var result = _calculator.Addition(1.5, 1.5);

            // Arrange
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Addition_Returns_Double()
        {
            // Act
            var resultType = _calculator.Addition(1, 1).GetType();
            var dType = typeof(double);

            // Assert
            Assert.AreEqual(dType, resultType);
        }

        //Division

        [Test]
        public void Division_Does_Division()
        {
            // Act
            var result = _calculator.Division(10, 5);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Division_Does_Division_With_Decimals()
        {
            // Act
            var result = _calculator.Division(10.5, 2);

            // Arrange
            Assert.AreEqual(5.25, result);
        }

        [Test]
        public void Division_Returns_Double()
        {
            // Act
            var resultType = _calculator.Division(10, 5).GetType();
            var dType = typeof(double);

            // Assert
            Assert.AreEqual(dType, resultType);
        }

        //Multiplication

        [Test]
        public void Multiplication_Does_Multiplication()
        {
            // Act
            var result = _calculator.Multiplication(5, 5);

            // Assert
            Assert.AreEqual(25, result);
        }

        [Test]
        public void Multiplication_Does_Multiplication_With_Decimals()
        {
            // Act
            var result = _calculator.Multiplication(10.25, 2);

            // Arrange
            Assert.AreEqual(20.5, result);
        }

        [Test]
        public void Multiplication_Returns_Double()
        {
            // Act
            var resultType = _calculator.Multiplication(10, 5).GetType();
            var dType = typeof(double);

            // Assert
            Assert.AreEqual(dType, resultType);
        }

        //Subtraction

        [Test]
        public void Subtraction_Does_Subtraction()
        {
            // Act
            var result = _calculator.Subtraction(4, 2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Subtraction_Does_Subtraction_With_Decimals()
        {
            // Act
            var result = _calculator.Subtraction(10.5, 2);

            // Arrange
            Assert.AreEqual(8.5, result);
        }

        [Test]
        public void Subtraction_Returns_Subtraction()
        {
            // Act
            var resultType = _calculator.Subtraction(10, 5).GetType();
            var dType = typeof(double);

            // Assert
            Assert.AreEqual(dType, resultType);
        }
    }
}