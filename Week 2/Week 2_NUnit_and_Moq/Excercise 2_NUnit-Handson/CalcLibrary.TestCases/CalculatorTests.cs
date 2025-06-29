using System;
using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private IMathLibrary calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Teardown()
        {
            if (calculator is SimpleCalculator calc)
            {
                calc.AllClear();
            }
        }

        [TestCase(1, 2, 3)]
        [TestCase(-5, 5, 0)]
        [TestCase(0, 0, 0)]
        public void Addition_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var sum = calculator.Addition(a, b);
            Assert.That(sum, Is.EqualTo(expected));
        }

        [TestCase(10, 4, 6)]
        [TestCase(-3, -6, 3)]
        public void Subtraction_ShouldReturnCorrectResult(double x, double y, double expected)
        {
            var result = calculator.Subtraction(x, y);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, 5, 10)]
        [TestCase(-3, 3, -9)]
        public void Multiplication_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var product = calculator.Multiplication(a, b);
            Assert.That(product, Is.EqualTo(expected));
        }

        [TestCase(8, 2, 4)]
        [TestCase(15, 3, 5)]
        public void Division_ShouldReturnCorrectResult(double dividend, double divisor, double expected)
        {
            var result = calculator.Division(dividend, divisor);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ShouldThrowArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => calculator.Division(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }

        [Test]
        public void AllClear_ShouldResetResultToZero()
        {
            var sc = new SimpleCalculator();
            sc.Addition(10, 5);
            Assert.That(sc.GetResult, Is.EqualTo(15));

            sc.AllClear();
            Assert.That(sc.GetResult, Is.EqualTo(0));
        }

        [Test, Ignore("Test not implemented yet")]
        public void FutureTest_Skipped()
        {
            Assert.Fail("This test is intentionally skipped.");
        }
    }
}
