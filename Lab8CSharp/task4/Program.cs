using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "powers_of_3.dat"; // Шлях до двійкового файлу

        // Створюємо або перезаписуємо файл
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            // Записуємо степені числа 3 (3^0, 3^1, 3^2, ...)
            for (int i = 0; i < 10; i++)
            {
                int powerOf3 = (int)Math.Pow(3, i);
                writer.Write(powerOf3);
            }
        }

        Console.WriteLine("Степені числа 3 записано в файл.");

        // Виведемо числа з парним порядковим номером
        DisplayEvenIndexedNumbers(filePath);
    }

    static void DisplayEvenIndexedNumbers(string filePath)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int index = 0;
            Console.WriteLine("Числа з парним порядковим номером:");

            // Читаємо файл і виводимо числа з парним порядковим номером
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                int number = reader.ReadInt32();
                if (index % 2 == 0)
                {
                    Console.WriteLine($"Індекс {index}: {number}");
                }
                index++;
            }
            Console.WriteLine("Enter...");
            Console.ReadLine();
        }
    }
}
