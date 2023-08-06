void Towers(string start = "1", string end = "3", string tmp = "2", int disk = 3)
{
    if (disk > 1) Towers(start, tmp, end, disk - 1);//поменяла функции шпилей местами
    Console.WriteLine($"{start} >> {end}");
    if (disk > 1) Towers(tmp, end, start, disk - 1);
}

Towers();

//with - шпиль, откуда берем блинчик; on - куда кладем; some - промежуточный шпиль
//count - кол-во блинчиков, которое у нас есть