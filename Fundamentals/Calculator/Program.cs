// Calculator Assignment

Console.WriteLine("Hello!");
Console.Write("Input the first number: ");
var firstNumber = int.Parse(Console.ReadLine());
Console.Write("Input the second number: ");
var secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var userChoice = Console.ReadLine();
Calculate(userChoice);


Console.WriteLine("Press any key to close");
Console.ReadKey();

void Calculate(string input)
{
    if (EqualsCaseSensitive(input,"A"))
    {
        printFinalEquation(firstNumber, secondNumber, Addition(firstNumber, secondNumber), "+");
    }
    else if (EqualsCaseSensitive(input, "S"))
    {
        printFinalEquation(firstNumber, secondNumber,Subtraction(firstNumber, secondNumber), "-");
    }
    else if (EqualsCaseSensitive(input, "M"))
    {
        printFinalEquation(firstNumber, secondNumber, Multiplication(firstNumber, secondNumber), "*");
    }
    else
    {
        Console.WriteLine("Invalid Option");
    }
}

bool EqualsCaseSensitive(string input, string compared)
{
    return input.ToUpper().Equals(compared.ToUpper());
}


int Addition(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;

}
int Subtraction(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}
int Multiplication(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}

void printFinalEquation(int number1, int number2, int result, string simbol)
{
    Console.WriteLine($"{number1} {simbol} {number2} = {result}"); 
}