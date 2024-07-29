using System;

class URI
{

    static void Main(string[] args)
    {

        int firstNumber, secondNumber, thirdNumber, fourthNumber, difference;

        firstNumber = int.Parse(Console.ReadLine());
        secondNumber = int.Parse(Console.ReadLine());
        thirdNumber = int.Parse(Console.ReadLine());
        fourthNumber = int.Parse(Console.ReadLine());

        difference = (firstNumber * secondNumber - thirdNumber * fourthNumber);
        Console.WriteLine($"DIFERENCA = {difference}");
        Console.ReadKey();


    }

}