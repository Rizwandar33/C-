int add(params int[] numbers)
{
    int sum = 0;
    foreach(int number in numbers)
    {
        sum += number;
    }
    return sum;
}
int[] numbers = { 100, 200, 300, 400, 500 };
int result = add(numbers);
Console.WriteLine($"The Sum is {result}");