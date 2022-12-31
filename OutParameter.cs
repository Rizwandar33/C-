void cal (int x, int y, out int sum, out int sub, out int mul)
{
    sum = x + y;
    sub = x - y;
    mul = x * y;
}
int x = 10;
int y = 20;
int sum , sub, mul;
cal (x, y, out sum,out sub, out mul);
Console.WriteLine($"The Sum is {sum} , The Sub is {sub} , The Mul is {mul}");