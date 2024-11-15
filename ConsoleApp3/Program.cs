using System;

namespace Week02_Assignment
{
    public class FermatChecker
    {
        public static void CheckFermat(int a, int b, int c, int n)
        {
            if (n > 2)
            {
                double leftSide = Math.Pow(a, n) + Math.Pow(b, n);
                double rightSide = Math.Pow(c, n);

                if (leftSide == rightSide)
                {
                    Console.WriteLine("Holy smokes, Fermat was wrong!");
                }
                else
                {
                    Console.WriteLine("No, that doesn’t work.");
                }
            }
            else
            {
                Console.WriteLine("Fermat's theorem applies only for n > 2.");
            }
        }

        public static void Main(string[] args)
        {
            CheckFermat(3, 4, 5, 3); // Checks to see of Fermat's Theorem works.
        }
    }
}
