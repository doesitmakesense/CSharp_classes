// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

// Как найти нужный символ в строке?
// номер строки и номер символа с нуля, например в string s = "qwerty"
// s[3] - symbol r in string s

// Метод будет принимать строку и те символы, которые нужно менять, и на 
// которые нужно заменить. Возвращаться будет строка.

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length; //кол-во символов в строке
    for (int i = 0; i < length; i++) //пробегаем от нулевого символа до конца строки
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '_');//указываем, что на что меняем
Console.WriteLine(newText);

Console.WriteLine(); //пустая строка для разделения

newText = Replace(text, 'с', 'С');//уже не объявляю переменную
Console.WriteLine(newText);

Console.WriteLine(); //пустая строка для разделения

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);