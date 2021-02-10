using System;
using NUnit.Framework;

namespace Calc.Test.Unit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddingTwoNumbers_EqualsToSum()
        {
            // Arrange
            var uut = new Calculator.Calculator();
            // Act
            double sum = uut.Add(2, 10);
            // Assert
            Assert.That(sum, Is.EqualTo(2+10));
        }

        [Test]
        public void SubtractingTwoNumbers_EqualsToSum()
        {
            // Arrange
            var uut = new Calculator.Calculator();
            // Act
            double sum = uut.Subtract(2, 10);
            // Assert
            Assert.That(sum, Is.EqualTo(2 - 10));
        }

        [Test]
        public void MultiplyingTwoNumbers_IsEqualToSum()
        {
            // Arrange
            var uut = new Calculator.Calculator();
            // Act
            double sum = uut.Multiply(2, 10);
            // Assert
            Assert.That(sum, Is.EqualTo(2 * 10));
        }

        [Test]
        public void BaseToThePowerOfExp_EqualsSum()
        {
            // Arrange
            var uut = new Calculator.Calculator();
            // Act
            double sum = uut.Power(2, 10);
            // Assert
            Assert.That(sum, Is.EqualTo(Math.Pow(2,10)));
        }

        
        
    }
}