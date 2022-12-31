
(int, int, int) Calculator(int x, int y)
{
    int sum = x + y;
    int sub = x - y;
    int mul = x * y;
    return (sum, sub, mul);
}
Console.WriteLine("Enter First Number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Secound Number");
int num2 = int.Parse(Console.ReadLine());
int sum, sub, mul;
(sum, sub, mul) = Calculator(num1, num2);
Console.WriteLine($"The Sum is {sum} and Sub is {sub} and Mul is {mul}");