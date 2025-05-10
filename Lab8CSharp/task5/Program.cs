using System;
using System.IO;
class Program
{
    static void Main()
    {
        string rootPath = @"d:\temp"; // Шлях до основної папки
        string studentLastName = "Шевченко"; // Прізвище студента
        // 1. Створюємо папки <прізвище_студента>1 і <прізвище_студента>2
        string path1 = Path.Combine(rootPath, studentLastName + "1");
        string path2 = Path.Combine(rootPath, studentLastName + "2");
        Directory.CreateDirectory(path1);
        Directory.CreateDirectory(path2);
        Console.WriteLine("Папки створено.");
        // 2. Створюємо файл t1.txt в папці <прізвище_студента>1
        string t1FilePath = Path.Combine(path1, "t1.txt");
        File.WriteAllText(t1FilePath, "<Шевченко Степан Іванович, 2001> року народження, місце проживання <м. Суми>");
        // 3. Створюємо файл t2.txt в папці <прізвище_студента>1
        string t2FilePath = Path.Combine(path1, "t2.txt");
        File.WriteAllText(t2FilePath, "<Комар Сергій Федорович, 2000> року народження, місце проживання <м. Київ>");
        Console.WriteLine("Файли t1.txt і t2.txt створено.");
        // 4. У папці <прізвище_студента>2 створюємо файл t3.txt і записуємо в нього текст з t1.txt та t2.txt
        string t3FilePath = Path.Combine(path2, "t3.txt");
        string text1 = File.ReadAllText(t1FilePath);
        string text2 = File.ReadAllText(t2FilePath);
        File.WriteAllText(t3FilePath, text1 + Environment.NewLine + text2);
        Console.WriteLine("Файл t3.txt створено і переписано.");
        // 5. Переносимо файл t2.txt в папку <прізвище_студента>2
        string t2NewPath = Path.Combine(path2, "t2.txt");
        File.Move(t2FilePath, t2NewPath);
        Console.WriteLine("Файл t2.txt перенесено в папку <прізвище_студента>2.");
        // 6. Копіюємо файл t1.txt в папку <прізвище_студента>2
        string t1CopyPath = Path.Combine(path2, "t1.txt");
        File.Copy(t1FilePath, t1CopyPath);
        Console.WriteLine("Файл t1.txt скопійовано в папку <прізвище_студента>2.");
        // 7. Перейменовуємо папку <прізвище_студента>2 в "ALL", видаляємо папку <прізвище_студента>1
        string allPath = Path.Combine(rootPath, "ALL");
        Directory.Move(path2, allPath);
        Directory.Delete(path1, true);
        Console.WriteLine("Папка <прізвище_студента>2 перейменована в ALL, папка <прізвище_студента>1 видалена.");
        // 8. Виводимо повну інформацію про файли в папці "ALL"
        Console.WriteLine("\nІнформація про файли в папці ALL:");
        foreach (var file in Directory.GetFiles(allPath))
        {
            FileInfo fileInfo = new FileInfo(file);
            Console.WriteLine($"Файл: {fileInfo.Name}");
            Console.WriteLine($"Шлях: {fileInfo.FullName}");
            Console.WriteLine($"Розмір: {fileInfo.Length} байт");
            Console.WriteLine($"Дата створення: {fileInfo.CreationTime}");
            Console.WriteLine($"Дата зміни: {fileInfo.LastWriteTime}");
            Console.WriteLine();
        }
            Console.WriteLine("Enter...");
            Console.WriteLine();
            Console.ReadLine();
    }
}
