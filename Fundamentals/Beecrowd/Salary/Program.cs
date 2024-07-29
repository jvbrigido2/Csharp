using System;

class URI
{

    static void Main(string[] args)
    {

        int employeeNumber, workedHours;
        double amountPerHour, salary;

        employeeNumber = int.Parse(Console.ReadLine());
        workedHours = int.Parse(Console.ReadLine());
        amountPerHour = double.Parse(Console.ReadLine());
        salary = workedHours * amountPerHour;


        Console.WriteLine($"NUMBER = {employeeNumber}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");

        Console.ReadKey();



    }

}