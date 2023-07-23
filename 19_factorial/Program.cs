double GetFactorial(int x)
{
    if (x <= 1) return 1;
    else return x * GetFactorial(x - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {GetFactorial(i)}");
}
