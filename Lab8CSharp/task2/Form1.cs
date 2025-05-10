using System;
using System.IO;
using System.Windows.Forms;

namespace WordSearchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string path = "input.txt";
            string outputPath = "output.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("Файл input.txt не знайдено.");
                return;
            }

            string text = File.ReadAllText(path);
            string searchWord = wordBox.Text;

            bool found = text.Contains(searchWord);
            string result = found
                ? $"Слово \"{searchWord}\" знайдено у тексті."
                : $"Слово \"{searchWord}\" не знайдено у тексті.";

            resultBox.Text = result;
            File.WriteAllText(outputPath, result);
        }
    }
}
