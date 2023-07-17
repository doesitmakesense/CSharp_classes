//Найти максимум из девяти чисел

// ччч int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result;
// }

// int a1 = 1;
// int a2 = 2;
// int a3 = 3;
// int a4 = 105;
// int a5 = 5;
// int a6 = 33;
// int a7 = 7;
// int a8 = 8;
// int a9 = 166;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(a4, a5, a6);
// int max3 = Max(a7, a8, a9);
// int max = Max(max1, max2, max3);

// ччч int max = Max(Max(a1, a2, a3),Max(a4, a5, a6), Max(a7, a8, a9));

// int max = a1;

// if (a2>max) max = a2;
// if (a3>max) max = a3;
// if (a4>max) max = a4;
// if (a5>max) max = a5;
// if (a6>max) max = a6;
// if (a7>max) max = a7;
// if (a8>max) max = a8;
// if (a9>max) max = a9;

// ччч Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; //возвращает результат
}
int a1 = 13;
int b1 = 45;
int c1 = 11;
int a2 = 13;
int b2 = 452;
int c2 = 111;
int a3 = 3;
int b3 = 85;
int c3 = 31;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);
Console.WriteLine(max);

