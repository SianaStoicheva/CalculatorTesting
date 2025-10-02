using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("cannot divide by zero");
            }
            return num1 / num2;
        }
        public int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
        public double Power(double a, double b)
        {
            if (b % 1 != 0)
            {
                throw new ArgumentException("Exponent must be integer.");
            }
            return Math.Pow(a, b);
        }
    }
}
