namespace Lab_1_WinForm2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SizeButton = new System.Windows.Forms.Button();
            this.GenerationButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SortedButton1 = new System.Windows.Forms.Button();
            this.SorteButton2 = new System.Windows.Forms.Button();
            this.SearchMAXbutton = new System.Windows.Forms.Button();
            this.SearchMINbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 51);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SizeButton
            // 
            this.SizeButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.SizeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.SizeButton.Location = new System.Drawing.Point(12, 46);
            this.SizeButton.Name = "SizeButton";
            this.SizeButton.Size = new System.Drawing.Size(115, 44);
            this.SizeButton.TabIndex = 2;
            this.SizeButton.Text = "Size";
            this.SizeButton.UseVisualStyleBackColor = false;
            this.SizeButton.Click += new System.EventHandler(this.SizeButton_Click);
            // 
            // GenerationButton
            // 
            this.GenerationButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.GenerationButton.ForeColor = System.Drawing.SystemColors.Info;
            this.GenerationButton.Location = new System.Drawing.Point(237, 46);
            this.GenerationButton.Name = "GenerationButton";
            this.GenerationButton.Size = new System.Drawing.Size(551, 44);
            this.GenerationButton.TabIndex = 3;
            this.GenerationButton.Text = "Сгенерировать коллекцию";
            this.GenerationButton.UseVisualStyleBackColor = false;
            this.GenerationButton.Click += new System.EventHandler(this.GenerationButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 44);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SortedButton1
            // 
            this.SortedButton1.BackColor = System.Drawing.SystemColors.GrayText;
            this.SortedButton1.ForeColor = System.Drawing.SystemColors.Info;
            this.SortedButton1.Location = new System.Drawing.Point(12, 196);
            this.SortedButton1.Name = "SortedButton1";
            this.SortedButton1.Size = new System.Drawing.Size(309, 83);
            this.SortedButton1.TabIndex = 5;
            this.SortedButton1.Text = "По возрастанию";
            this.SortedButton1.UseVisualStyleBackColor = false;
            this.SortedButton1.Click += new System.EventHandler(this.SortedButton1_Click);
            // 
            // SorteButton2
            // 
            this.SorteButton2.BackColor = System.Drawing.SystemColors.GrayText;
            this.SorteButton2.ForeColor = System.Drawing.SystemColors.Info;
            this.SorteButton2.Location = new System.Drawing.Point(12, 303);
            this.SorteButton2.Name = "SorteButton2";
            this.SorteButton2.Size = new System.Drawing.Size(309, 85);
            this.SorteButton2.TabIndex = 6;
            this.SorteButton2.Text = "По убыванию";
            this.SorteButton2.UseVisualStyleBackColor = false;
            this.SorteButton2.Click += new System.EventHandler(this.SorteButton2_Click);
            // 
            // SearchMAXbutton
            // 
            this.SearchMAXbutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.SearchMAXbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.SearchMAXbutton.Location = new System.Drawing.Point(475, 196);
            this.SearchMAXbutton.Name = "SearchMAXbutton";
            this.SearchMAXbutton.Size = new System.Drawing.Size(313, 83);
            this.SearchMAXbutton.TabIndex = 7;
            this.SearchMAXbutton.Text = "Максимальный элемент";
            this.SearchMAXbutton.UseVisualStyleBackColor = false;
            this.SearchMAXbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // SearchMINbutton
            // 
            this.SearchMINbutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.SearchMINbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.SearchMINbutton.Location = new System.Drawing.Point(475, 303);
            this.SearchMINbutton.Name = "SearchMINbutton";
            this.SearchMINbutton.Size = new System.Drawing.Size(313, 85);
            this.SearchMINbutton.TabIndex = 8;
            this.SearchMINbutton.Text = "Минимальный элемент";
            this.SearchMINbutton.UseVisualStyleBackColor = false;
            this.SearchMINbutton.Click += new System.EventHandler(this.SearchMINbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchMINbutton);
            this.Controls.Add(this.SearchMAXbutton);
            this.Controls.Add(this.SorteButton2);
            this.Controls.Add(this.SortedButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.GenerationButton);
            this.Controls.Add(this.SizeButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SizeButton;
        private System.Windows.Forms.Button GenerationButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SortedButton1;
        private System.Windows.Forms.Button SorteButton2;
        private System.Windows.Forms.Button SearchMAXbutton;
        private System.Windows.Forms.Button SearchMINbutton;
    }
}

