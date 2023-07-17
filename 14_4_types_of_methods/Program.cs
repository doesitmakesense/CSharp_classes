void Method1()
{
    Console.WriteLine("Author ..."); //Ex: I want to write author in the end
    //of every programm
}
Method1(); //Call this type of method like this

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); //Call this type of method 

//Вариант с двумя аргументами:

void Method2_1(string msg, int count)
{
    for (int i = 0; i < count; i++)
    {
    Console.WriteLine(msg);
    }
}
// Method2(msg:"Текст",count: 4); //Told it how many times I want it to be printed
Method2_1(count: 4, msg:"Другой текст"); //Can do this way
//Not necessary to use msg and count in command

//NOT RECEIVING BUT RETURNING SOMETHING METHODS:

//Если метод что-то возвращает, обязательно нужно указать тип данных,
//которые мы ожидаем получить на возврате

int Method3()
{
    return DateTime.Now.Year; //here something happens (some work)
}

int year = Method3(); // result of the work will be put in int year
Console.WriteLine(year);

//SOMETHING RECEIVE, SOMETHING RETURN METHODS

string Method4(int count,string text) //we will return string; будем строку
//c компоновать count раз
{
//     int i = 0;
//     string result = String.Empty;//сюда будем класть значение, это 
// //изначально пустая строка
// while (i < count)
// {
// result = result + text;
// i++;
// }
// return result; //цикл отработал, говорим вернуть нам результат
string result = String.Empty;
for (int i = 0; i < count; i++)
{
    result = result + text;
}
return result;
}
string res = Method4(text: "New text ", count: 10); //вызываем метод, создав для него вообще
//другую переменную, и говорим ему 10 раз напиши этот текст
Console.WriteLine(res);

//ЦИКЛ В ЦИКЛЕ. Например, если нужно закрасить прямоуг.область

//Классика - вывод таблицы умножения (2-10) на экран:

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}