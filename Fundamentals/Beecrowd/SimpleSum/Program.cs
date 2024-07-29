using System;

class URI
{

    static void Main(string[] args)
    {

       int firstNumber, secondNumber, sum;

        firstNumber = int.Parse(Console.ReadLine());
        secondNumber = int.Parse(Console.ReadLine());

        sum = firstNumber + secondNumber;

        Console.WriteLine($"SOMA = {sum}");
        Console.ReadKey();

    }

}
