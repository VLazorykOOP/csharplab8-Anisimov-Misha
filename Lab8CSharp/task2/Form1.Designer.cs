namespace WordSearchApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.wordBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // wordBox
            this.wordBox.Location = new System.Drawing.Point(25, 35);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(200, 22);

            // checkButton
            this.checkButton.Location = new System.Drawing.Point(25, 70);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 30);
            this.checkButton.Text = "Перевірити";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);

            // resultBox
            this.resultBox.Location = new System.Drawing.Point(25, 115);
            this.resultBox.Multiline = true;
            this.resultBox.Size = new System.Drawing.Size(300, 60);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Text = "Введіть слово для пошуку:";

            // Form1
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "Пошук слова у файлі";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
