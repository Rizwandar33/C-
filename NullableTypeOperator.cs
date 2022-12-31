using System;
internal class NullableType
{ 
    public static void Main(string [] args)
    {
        int? num1 = null;
        int? num2 = 456;
        int num3 = num1 ?? 333;
        Console.WriteLine("the value of num3 when we use num1 is " + num3);
        int num4 = num2 ?? 333;
        Console.WriteLine("the value of num4 when we use num2 is " + num4);
    }
}