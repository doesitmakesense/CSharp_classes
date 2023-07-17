// Было: 6 8 3 2 1 4 5 7
// Стало: 1 8 3 2 6 4 5 7

// Смысл: берем первый элемент, в оставшейся части находим минимальный,
// меняем их местами. Берем второй элемент, ищем минимальный в оставшейся части
// минимальный, меняем местами. И так далее. 

int[] array = { 6, 8, 3, 2, 1, 4, 5, 7 };

void PrintArray(int[] array)
{
    int length = array.Length; // сколько элементов в массиве?
    for (int i = 0; i < length; i++) //пробежка по всем элементам и вывод
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void Reverse (int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temp = array[i];//временная перем, куда пишем рабочую первую
        array[i] = array[maxPosition]; //сюда положим то, что в процессе кода
        array[maxPosition] = temp;
        //это простой обмен двух переменных местами
    }
}

//Пишем метод, который будет упорядочивать массив
void SelectionSOrt(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];//временная перем, куда пишем рабочую первую
        array[i] = array[minPosition]; //сюда положим то, что в процессе кода
        array[minPosition] = temp;
        //это простой обмен двух переменных местами
    }
}

PrintArray(array);
SelectionSOrt(array);

PrintArray(array);
Reverse(array);

PrintArray(array);