int multiplication(int N)
{
    int sum = 1;
    int i = 2;
    if (N < 0)
    {
        i = N;
        N = -1;
    }
    for (; i <= N; i++)
    {   
        sum = sum * i;
    }
    return sum;
}

Console.Write("Произведение чисел от 1(-1) до N, ведите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"{multiplication(N)}");