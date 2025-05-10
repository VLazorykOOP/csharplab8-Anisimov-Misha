using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputPath = "input.txt";
        string datesOutputPath = "dates.txt";
        string finalOutputPath = "output.txt";

        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Файл input.txt не знайдено. Створіть його в тій же папці, що й .exe.");
            return;
        }

        string text = File.ReadAllText(inputPath);
        string pattern = @"\b(0?[1-9]|[12][0-9]|3[01])\.(0?[1-9]|1[0-2])\.(19\d{2}|20\d{2})\b";

        MatchCollection matches = Regex.Matches(text, pattern);
        List<string> validDates = new List<string>();

        foreach (Match match in matches)
        {
            string[] parts = match.Value.Split('.');
            int day = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int year = int.Parse(parts[2]);

            if (day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1900 && year <= 2099)
            {
                validDates.Add(match.Value);
            }
        }
        File.WriteAllLines(datesOutputPath, validDates);
        Console.WriteLine($"Знайдено {validDates.Count} валідних дат. Записано у {datesOutputPath}.");
        Console.Write("Введіть дату, яку потрібно замінити (дд.мм.рррр): ");
        string dateToReplace = Console.ReadLine();
        Console.Write("Введіть нову дату для заміни: ");
        string newDate = Console.ReadLine();
        string replacedText = text.Replace(dateToReplace, newDate);
        File.WriteAllText(finalOutputPath, replacedText);
        Console.WriteLine($"Усі входження \"{dateToReplace}\" замінено на \"{newDate}\". Результат збережено в {finalOutputPath}.");
        Console.WriteLine("Enter...");
        string endProgram123 = Console.ReadLine();
    }
}
