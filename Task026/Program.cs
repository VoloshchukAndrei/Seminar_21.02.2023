int Quantity(int N)
{
    int count = 0;
    if (N < 1)
    {
        N *= (-1);
    }
    while (N >= 1)
    {
        N = N / 10;
        count++;
    }
    return count;
}

Console.Write("Определение количества символов в числе, ведите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"{Quantity(N)}");