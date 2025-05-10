namespace DoubleLetterWordsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox doubledBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.doubledBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // doubledBox
            this.doubledBox.Location = new System.Drawing.Point(25, 45);
            this.doubledBox.Multiline = true;
            this.doubledBox.Size = new System.Drawing.Size(350, 60);
            this.doubledBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Додаємо прокручування

            // resultBox
            this.resultBox.Location = new System.Drawing.Point(25, 140);
            this.resultBox.Multiline = true;
            this.resultBox.Size = new System.Drawing.Size(350, 100);
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Додаємо прокручування

            // processButton
            this.processButton.Location = new System.Drawing.Point(25, 250);
            this.processButton.Size = new System.Drawing.Size(150, 30);
            this.processButton.Text = "Обробити текст";
            this.processButton.Click += new System.EventHandler(this.processButton_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Text = "Вилучені слова з подвоєнням літер:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Text = "Текст без вилучених слів:";

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doubledBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.processButton);
            this.Name = "Form1";
            this.Text = "Обробка тексту";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
