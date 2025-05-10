using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DoubleLetterWordsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            string inputFile = "input.txt";
            string outputFile = "output.txt";

            if (!File.Exists(inputFile))
            {
                MessageBox.Show("Файл input.txt не знайдено.");
                return;
            }

            string text = File.ReadAllText(inputFile);

            // Отримуємо всі слова
            var words = Regex.Matches(text, @"\b[\wА-Яа-яїієґ]+\b")
                             .Cast<Match>()
                             .Select(m => m.Value)
                             .ToList();

            // Визначаємо слова з подвоєнням літер (наприклад: "letter", "мама", "coffee")
            var doubledWords = words.Where(w => Regex.IsMatch(w, @"(\w)\1", RegexOptions.IgnoreCase)).ToList();

            // Очищений текст
            var cleanedText = string.Join(" ", words.Except(doubledWords));

            // Виводимо на форму
            doubledBox.Text = string.Join(" ", doubledWords);
            resultBox.Text = cleanedText;

            // Запис у файл
            File.WriteAllText(outputFile, $"Вилучені слова:\n{string.Join(" ", doubledWords)}\n\nЗалишений текст:\n{cleanedText}");
        }
    }
}
