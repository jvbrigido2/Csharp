using System;

class URI
{

    static void Main(string[] args)
    {

        int firstNumber, secondNumber, prod;
        firstNumber = int.Parse(Console.ReadLine());
        secondNumber = int.Parse(Console.ReadLine());
        prod = firstNumber * secondNumber;

        Console.WriteLine($"PROD = {prod}");
        Console.ReadKey();

    }

}