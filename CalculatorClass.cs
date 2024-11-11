using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate double Formula(double arg1, double arg2);

    public class CalculatorClass
    {
        // Declare the delegate variable
        public Formula Calculation;

        // Method to add two numbers
        public double GetSum(double num1, double num2) => num1 + num2;

        // Method to subtract two numbers
        public double GetDifference(double num1, double num2) => num1 - num2;

        // Method to multiply two numbers
        public double GetProduct(double num1, double num2) => num1 * num2;

        // Method to divide two numbers, with a check for division by zero
        public double GetQuotient(double num1, double num2) => num2 != 0 ? num1 / num2 : double.NaN;
    }

}
