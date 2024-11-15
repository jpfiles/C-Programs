using System;

class Program
{
    static void Main()
    {
        double x1, volume, f;
        double a = 1.0, b = 2.83, c = 1.2;
        double r = 1.0;
        double theta = 0.523599;

        // Formula 1
        x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

        // Formula 2
        volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

        // Formula 3
        f = Math.Pow(Math.Sin(theta), 2) + Math.Pow(Math.Cos(theta), 2);

        // Output the results
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"volume = {volume}");
        Console.WriteLine($"f = {f}");
    }
}

