namespace Exercise_6._2
{
    internal class Program
    {
        // Original codeo from Exercise 6.2
        //static void Main(string[] args)
        //{
        //    double count = 0.0;
        //    while (count != 1.0)
        //    {
        //        count = count + 0.1;
        //        Console.Write("{0:R}", count);
        //        Console.ReadLine();
        //    }
        //}

        static void Main(string[] args)
        {
            double count = 0.0;
            double epsilon = 0.0001; // Small margin of error

            while (Math.Abs(count - 1.0) > epsilon)
            {
                count += 0.1;
                Console.WriteLine("{0:R}", count);
                Console.ReadLine();
            }
        }

    }
}