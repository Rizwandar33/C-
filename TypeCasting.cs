using System;
internal class TypeCasting
{ 
public static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        long z = x + y;//implicit casting
        Console.WriteLine($"The Sum of {x} and {y} is {z}");
        int num = 123456;
        long num1 = num;
        Console.WriteLine($"The Value is {num1}");
        long num2 = 334;
        int num3 = (int)num2; //long into int
        Console.WriteLine($"The Value after Explicit type casting is {num3}");// explicit type casting
        double dbl = 1234.5;
        int dblint = (int)dbl;
        Console.WriteLine($"The Value after Explicitly casting doulbe into int is {dblint}");

    }
}