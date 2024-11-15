using System;

namespace Exercise_6._3
{
    public class SquareRootCalculator
    {
        public static double SquareRoot(double a)
        {
            // Initial guess
            double x0 = a / 2;
            double x1 = (x0 + a / x0) / 2;

            // Iterate until the difference between consecutive estimates is less than 0.0001
            while (Math.Abs(x1 - x0) >= 0.0001)
            {
                x0 = x1;
                x1 = (x0 + a / x0) / 2;
            }

            return x1;
        }

        public static void Main(string[] args)
        {
            double number = 9.0;
            double result = SquareRoot(number);
            Console.WriteLine($"The approximate square root of {number} is {result}");
        }
    }
}
