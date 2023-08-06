// string path = "C:/Users/Omen/Downloads/CSharp/CSharp_classes/1_hello";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

void CatalogInfo(string path, string indent = "") // string indent = искусств.прием для отступов
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories(); // получаем массив всех файлов директории
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles(); //получаем весь список файлов текущего каталога
                                           // покажем их:
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"C:\Users\Omen\Downloads\CSharp\CSharp_classes"; // с собакой не надо слэши править
CatalogInfo(path);