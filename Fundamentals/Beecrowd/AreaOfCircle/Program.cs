using System;

class URI
{

    static void Main(string[] args)
    {

        const double N = 3.14159;

        double r = double.Parse(Console.ReadLine());

        double a = N * r * r;
        Console.WriteLine($"A={a:F4}");

        Console.ReadKey();

    }

}
