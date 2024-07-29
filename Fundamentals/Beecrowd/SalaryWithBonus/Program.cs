using System;

class URI
{

    static void Main(string[] args)
    {

        string employeeName;
        double salaryBase, totalSold, totalSalary;

        employeeName = Console.ReadLine();
        salaryBase = Convert.ToDouble(Console.ReadLine());
        totalSold = Convert.ToDouble(Console.ReadLine());

        totalSalary = salaryBase + totalSold * 0.15;

        Console.WriteLine($"TOTAL = R$ {totalSalary:F2}");
        Console.ReadKey();

    }

}
