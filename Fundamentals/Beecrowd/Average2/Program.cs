using System;

class URI
{

    static void Main(string[] args)
    {

       double firstNumber, secondNumber, thirdNumber, average;
       firstNumber = double.Parse(Console.ReadLine());
       secondNumber = double.Parse(Console.ReadLine());
       thirdNumber = double.Parse(Console.ReadLine());

       average = (firstNumber * 2 + secondNumber * 3 + thirdNumber * 5) / 10;
       Console.WriteLine($"MEDIA = {average:F1}");
       Console.ReadKey();

    }

}
