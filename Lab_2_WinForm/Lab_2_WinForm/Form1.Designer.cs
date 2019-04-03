namespace Lab_2_WinForm
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
            this.RoomsNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MetrComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FLOORnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.HouseAge = new System.Windows.Forms.DateTimePicker();
            this.HouseAgeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddAdressButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsNumericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FLOORnumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsNumericUpDown1
            // 
            this.RoomsNumericUpDown1.Location = new System.Drawing.Point(126, 28);
            this.RoomsNumericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.RoomsNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoomsNumericUpDown1.Name = "RoomsNumericUpDown1";
            this.RoomsNumericUpDown1.Size = new System.Drawing.Size(54, 22);
            this.RoomsNumericUpDown1.TabIndex = 0;
            this.RoomsNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoomsNumericUpDown1.ValueChanged += new System.EventHandler(this.RoomsNumericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Комнаты:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 161);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(94, 21);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Спальная";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 133);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Гостинная";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 105);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Подвал";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Балкон";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Санузел";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Кухня";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MetrComboBox
            // 
            this.MetrComboBox.FormattingEnabled = true;
            this.MetrComboBox.Location = new System.Drawing.Point(12, 289);
            this.MetrComboBox.Name = "MetrComboBox";
            this.MetrComboBox.Size = new System.Drawing.Size(168, 24);
            this.MetrComboBox.TabIndex = 2;
            this.MetrComboBox.SelectedIndexChanged += new System.EventHandler(this.MetrComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кол-во комнат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Метраж:";
            // 
            // FLOORnumericUpDown2
            // 
            this.FLOORnumericUpDown2.Location = new System.Drawing.Point(126, 339);
            this.FLOORnumericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.FLOORnumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FLOORnumericUpDown2.Name = "FLOORnumericUpDown2";
            this.FLOORnumericUpDown2.Size = new System.Drawing.Size(54, 22);
            this.FLOORnumericUpDown2.TabIndex = 7;
            this.FLOORnumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Этаж:";
            // 
            // HouseAge
            // 
            this.HouseAge.Location = new System.Drawing.Point(12, 416);
            this.HouseAge.Name = "HouseAge";
            this.HouseAge.Size = new System.Drawing.Size(168, 22);
            this.HouseAge.TabIndex = 9;
            this.HouseAge.ValueChanged += new System.EventHandler(this.HouseAge_ValueChanged);
            // 
            // HouseAgeLabel
            // 
            this.HouseAgeLabel.AutoSize = true;
            this.HouseAgeLabel.Location = new System.Drawing.Point(19, 393);
            this.HouseAgeLabel.Name = "HouseAgeLabel";
            this.HouseAgeLabel.Size = new System.Drawing.Size(119, 17);
            this.HouseAgeLabel.TabIndex = 10;
            this.HouseAgeLabel.Text = "Дата постройки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Адрес";
            // 
            // AddAdressButton
            // 
            this.AddAdressButton.Location = new System.Drawing.Point(302, 297);
            this.AddAdressButton.Name = "AddAdressButton";
            this.AddAdressButton.Size = new System.Drawing.Size(160, 53);
            this.AddAdressButton.TabIndex = 12;
            this.AddAdressButton.Text = "Добавить";
            this.AddAdressButton.UseVisualStyleBackColor = true;
            this.AddAdressButton.Click += new System.EventHandler(this.AddAdressButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(572, 369);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(216, 69);
            this.OutputButton.TabIndex = 13;
            this.OutputButton.Text = "Вывести";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 69);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить в XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(302, 377);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(160, 53);
            this.AddRoomButton.TabIndex = 15;
            this.AddRoomButton.Text = "Добавить";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Комната";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(554, 233);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.AddAdressButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HouseAgeLabel);
            this.Controls.Add(this.HouseAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FLOORnumericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MetrComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomsNumericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RoomsNumericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FLOORnumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown RoomsNumericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox MetrComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FLOORnumericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker HouseAge;
        private System.Windows.Forms.Label HouseAgeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddAdressButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

