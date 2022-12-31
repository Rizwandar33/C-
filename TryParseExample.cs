using System;
internal class TryParseExample
{ 
 public static void Main(string[] args)
    {
        Console.WriteLine("Enter Salary");
        string salary = Console.ReadLine();
        Console.WriteLine("Enter Bonus");
        string bonus = Console.ReadLine();
        bool isSalConverted = int.TryParse(salary, out int sal);
        bool isBonusConverted = int.TryParse(bonus, out int bon);
        if (isSalConverted)
        {
            if (isBonusConverted)
            {
                int totalSalary = sal + bon;
                Console.WriteLine($"The Basic Salary is {totalSalary} ");
            }
            else
            {
                Console.WriteLine("Bonus is not converted");
            }
        }
        else
        {
            Console.WriteLine("Salary is not converted");
        }
    }
}
