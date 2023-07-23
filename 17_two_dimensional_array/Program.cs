// two - dimensional arrays - двумерные массивы
// string[,] table = new string[2, 3];//до зпт строчки, после столбцы
// int[,]matrix = new int[5,8]; //прямоуг.таблица чисел
// rows - ряды, columns - столбцы

//Делаем таблицу строк:

string[,] table = new string[2, 5]; //2 строчки, 5 столбцов
// строчек две, но мы всегда считаем с нуля, так что 0 и 1
// столбцов соответственно 5, значит 0 1 2 3 4

// String.Epmty
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

table[1, 2] = "word"; // в первой строчке и втором столбце будет слово word
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"--{table[rows, columns]}--");//вывод просто в столб из-за Line
    }
}

int[,] matrix = new int[3, 4];
for (int rows = 0; rows < matrix.GetLength(0); rows++) //0 - это первое измерение, наше до зпт
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++) //1 - второе измерение, после зпт
    {
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine(); //чтобы столбики были столбиками, а строчки строчками
}

//Печатаем двумерный массив, заполненный цифрами

void GenerateArray(int[,] matrix, int min, int max)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(min, max + 1);
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int min = GetInput("Введите минимальное значение для чисел массива: ");
int max = GetInput("Введите максимальное значение для чисел массива: ");
int[,] matrix = new int[3, 4];
GenerateArray(matrix, min, max);
