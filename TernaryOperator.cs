using System;
internal class TernaryOperator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter day Number");
        int dayNo = int.Parse(Console.ReadLine());
        string result = (dayNo == 1) ? "Monday" :
                        (dayNo == 2) ? "Tuesday" :
                        (dayNo == 3) ? "Wednesday" :
                        (dayNo == 4) ? "Thursday" :
                        (dayNo == 5) ? "Friday" :
                        (dayNo == 4) ? "Saturday" :
                        (dayNo == 4) ? "Sunday" :
                        "Invalid DayNo";
        Console.WriteLine(result);
    }
}