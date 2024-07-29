using System;

class URI
{

    static void Main(string[] args)
    {

        double firstNumber, secondNumber, average;

        firstNumber = double.Parse(Console.ReadLine());
        secondNumber = double.Parse(Console.ReadLine());

        average = (firstNumber * 3.5 + secondNumber * 7.5) / 11;

        Console.WriteLine($"MEDIA = {average:F5}");
        Console.ReadKey();

    }

}
