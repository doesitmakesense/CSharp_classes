// a в степени n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // тернарный оператор
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));

//Вариант с учетом математики, для четной степени, чтобы уменьшить кол-во ходов:

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRec(a * a, n / 2);
    else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(2, 10));