//Первое решение - обычным путем, второе - рекурсией

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

string NumbersRec(int a, int b) //тут на один проход меньше будет
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{a}";
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

//Если условие будет от большего к меньшему:

string NumbersFor1(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec1(int a, int b) //выводит только 10 и 9
{
    if (a > b) return $"{a} " + NumbersRec1(a - 1, b);
    else return $"{a}";
}

Console.WriteLine(NumbersFor1(10, 1));
Console.WriteLine(NumbersRec1(10, 1));