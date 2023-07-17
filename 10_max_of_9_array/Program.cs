int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int[]array =  {1, 2, 3, 105, 5, 33, 7, 8, 166}; //вместо выписывания девяти 
//интов в столбик. Дальше считаем индексы (в этом случае от 0 до 8)
//если щас сделаю команду 
// array[0]=12;
// Console.WriteLine(array[0]);
//то это я вместо единицы сделаю 12. Можно и просто вывести так элемент массива

int max = Max(Max(array[0], array[1], array[2]),
          Max(array[3], array[4], array[5]),
          Max(array[6], array[7], array[8]));

Console.WriteLine(max);