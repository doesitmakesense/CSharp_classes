//Как взять метод, передать в него массив, и заполнить массив нужным кол-вом 
//элементов
//И вывести все элементы по порядку
// И превратить код поиска нужного индекса в метод

void FillArray(int[] collection) //void ключевое слово, если метод ничего не 
//возвращает, то это метод void, тогда не пишем return
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10);
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

int[]array = new int[10]; //construction: create array with 10 elements

FillArray(array); //метод заполнил массив (рандомными числами)
PrintArray(array); //метод распечатал массив