using NUnit.Framework;
using System;
using CalculatorApp;

namespace CalculatorTest
{
    public class Tests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TestCase(7, 4, 11)] //7 + 4 = 11
        [TestCase(-8, 5, -3)] //-8 + 5 = -3
        [TestCase(0, 12, 12)] //0 + 12 = 12
        [TestCase(15, -7, 8)] //15 + (-7) = 8
        [TestCase(-10, -5, -15)] //-10 + -5 = -15
        public void SumTest(int n1, int n2, int r)
        {
            Assert.That(calc.Sum(n1, n2), Is.EqualTo(r));
        }

        [TestCase(15, 6, 9)] //15 - 6 = 9
        [TestCase(-4, 9, -13)] //-4 - 9 = -13
        [TestCase(20, -5, 25)] //20 - (-5) = 25
        [TestCase(-12, -3, -9)] //-12 - (-3) = -9
        [TestCase(0, 11, -11)] //0 - 11 = -11
        public void SubtractTest(int n1, int n2, int r)
        {
            Assert.That(calc.Subtract(n1, n2), Is.EqualTo(r));
        }

        [TestCase(3, 9, 27)] //3 * 9 = 27
        [TestCase(-5, 7, -35)] //-5 * 7 = -35
        [TestCase(8, -4, -32)] //8 * -4 = -32
        [TestCase(-6, -2, 12)] //-6 * -2 = 12
        [TestCase(0, 13, 0)] //0 * 13 = 0
        public void MultiplyTest(int n1, int n2, int r)
        {
            Assert.That(calc.Multiply(n1, n2), Is.EqualTo(r));
        }
        [TestCase(20, 4, 5)]   // 20 / 4 = 5
        [TestCase(-18, 6, -3)] // -18 / 6 = -3
        [TestCase(42, -7, -6)] // 42 / -7 = -6
        [TestCase(-24, -8, 3)] // -24 / -8 = 3
        [TestCase(0, 9, 0)]    // 0 / 9 = 0
        public void DivideValidIntTest(int n1, int n2, int r)
        {
            Assert.That(calc.Divide(n1, n2), Is.EqualTo(r));
        }
        [TestCase(14, 0)]      // 14 / 0 -> Exception
        [TestCase(-25, 0)]     // -25 / 0 -> Exception
        [TestCase(0, 0)]       // 0 / 0 -> Exception
        public void DivideByZeroIntTest(int n1, int n2)
        {
            Assert.That(() => calc.Divide(n1, n2), Throws.TypeOf<DivideByZeroException>());
        } 
        [TestCase(10.0, 2.0, 5.0)] //10 / 2 = 5
        [TestCase(-9.0, 3.0, -3.0)] //-9 / 3 = -3
        [TestCase(7.5, 2.5, 3.0)]  //7.5 / 2.5 = 3
        [TestCase(-8.0, -2.0, 4.0)] //-8 / -2 = 4
        [TestCase(0.0, 7.0, 0.0)] //0 / 7 = 0 

        public void DivideValidDoubleTest(double n1, double n2, double expected)
        {
            Assert.That(calc.Divide((int)n1, (int)n2), Is.EqualTo(expected));
        }

        [TestCase(5.0, 0.0)] //5 / 0 ? Exception
        [TestCase(-12.5, 0.0)] //-12.5 / 0 ? Exception
        [TestCase(0.0, 0.0)] //0 / 0 ? Exception
        public void DivideByZeroDoubleTest(double n1, double n2)
        {
            Assert.That(() => calc.Divide((int)n1, (int)n2), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(2, 4, 16)] //2^4 = 16
        [TestCase(5, 3, 125)] //5^3 = 125
        [TestCase(9, 2, 81)] //9^2 = 81
        [TestCase(7, 1, 7)] //7^1 = 7
        [TestCase(0, 5, 0)] //0^5 = 0
        [TestCase(6, 0, 1)] //6^0 = 1
        public void PowerIntExponentTest(int n1, int n2, int r)
        {
            Assert.That(calc.Power(n1, n2), Is.EqualTo(r));
        }

        [TestCase(2, 2.5)] // 2^2.5 ? Exception
        [TestCase(5, -1.3)] // 5^-1.3 ? Exception
        [TestCase(9, 0.7)] // 9^0.7 ? Exception
        [TestCase(-4, 1.2)] // (-4)^1.2 ? Exception
        [TestCase(10, -0.5)] // 10^-0.5 ? Exception
        public void PowerNonIntegerExponent_Throws(double a, double b)
        {
            Assert.That(() => calc.Power(a, b), Throws.TypeOf<ArgumentException>());
        }
    }
}
