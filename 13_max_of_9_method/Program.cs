// Ищем позицию нужного элемента с помощью метода
//он должен возвращать индекс, поэтому не void


void FillArray(int[] collection) //void ключевое слово, если метод ничего не 
//возвращает, то это метод void, тогда не пишем return
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; //обозначили кол-во элементом
    int position = 0; //позиция вместо индекса, чтобы другое слово
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
} //будет печатать массив

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //в эту переменную будем сохранять позицию, если совпала
    //-1 это потому, что если мы ищем число, а оно не выпало, нам покажет 0 индекс
    //а это неправильно, так что пусть -1. Можно это вывести типа "не найден"


    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //иначе если будет два числа, то второе покажет, а так первое
        }
        index++;
    }
    return position; //после того как цикл отработает, пусть нам вернет
}

int[] array = new int[10]; //construction: create array with 10 elements

FillArray(array); //метод заполнил массив (рандомными числами)
PrintArray(array); //метод распечатал массив

Console.WriteLine(); //пустая строка, чтобы отделить вывод массива 
//(предыдущая команда) от позиции

int pos = IndexOf(array, 4); //отдали массив в работу, а ищем 4
Console.WriteLine(pos);