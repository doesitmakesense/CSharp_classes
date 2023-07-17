Console.Clear(); //очистка консоли, там же рисовашки будут

int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30; //40 у первого это середина 80, чтобы первая точка стояла на середине
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+"); //теперь запускаем, и он рисует три точки
int x = xa, y = xb; //делаю точки и кладу в них первую точку, дальше все для 
//первой точки
int count = 0; //будет считать сколько раз считать
while (count < 100000) //10 точек мало, берем побольше
{
    int what = new Random().Next(0, 3); //генерируем случайное число what от 0 до 2вкл
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    //дальше делаем для второй и третьей точки (what ==1, ==2)
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;

        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y); //ставим курсор в позицию
    Console.WriteLine("+");
    count++; //говорим каунту увеличиваться на единицу
}