namespace TPLABA2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaxSpeed = new System.Windows.Forms.Label();
            this.MaxCountPassenger = new System.Windows.Forms.Label();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.MaxCountPassengertextBox = new System.Windows.Forms.TextBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.SetSamoletButton = new System.Windows.Forms.Button();
            this.SetFrontovoibombardirButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Weight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.SetdopColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 357);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.AutoSize = true;
            this.MaxSpeed.Location = new System.Drawing.Point(21, 456);
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Size = new System.Drawing.Size(78, 17);
            this.MaxSpeed.TabIndex = 1;
            this.MaxSpeed.Text = "Max Speed";
            // 
            // MaxCountPassenger
            // 
            this.MaxCountPassenger.AutoSize = true;
            this.MaxCountPassenger.Location = new System.Drawing.Point(21, 498);
            this.MaxCountPassenger.Name = "MaxCountPassenger";
            this.MaxCountPassenger.Size = new System.Drawing.Size(138, 17);
            this.MaxCountPassenger.TabIndex = 2;
            this.MaxCountPassenger.Text = "MaxCountPassenger";
            this.MaxCountPassenger.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(153, 454);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(75, 22);
            this.MaxSpeedTextBox.TabIndex = 3;
            // 
            // MaxCountPassengertextBox
            // 
            this.MaxCountPassengertextBox.Location = new System.Drawing.Point(187, 495);
            this.MaxCountPassengertextBox.Name = "MaxCountPassengertextBox";
            this.MaxCountPassengertextBox.Size = new System.Drawing.Size(77, 22);
            this.MaxCountPassengertextBox.TabIndex = 4;
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(812, 510);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(114, 35);
            this.MoveButton.TabIndex = 5;
            this.MoveButton.Text = "Движение";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // SetSamoletButton
            // 
            this.SetSamoletButton.Location = new System.Drawing.Point(280, 532);
            this.SetSamoletButton.Name = "SetSamoletButton";
            this.SetSamoletButton.Size = new System.Drawing.Size(198, 41);
            this.SetSamoletButton.TabIndex = 6;
            this.SetSamoletButton.Text = "Задать самолёт";
            this.SetSamoletButton.UseVisualStyleBackColor = true;
            this.SetSamoletButton.Click += new System.EventHandler(this.SetSamoletButton_Click);
            // 
            // SetFrontovoibombardirButton
            // 
            this.SetFrontovoibombardirButton.Location = new System.Drawing.Point(535, 529);
            this.SetFrontovoibombardirButton.Name = "SetFrontovoibombardirButton";
            this.SetFrontovoibombardirButton.Size = new System.Drawing.Size(191, 52);
            this.SetFrontovoibombardirButton.TabIndex = 7;
            this.SetFrontovoibombardirButton.Text = "Задать Фронтовой Бомбардировщик";
            this.SetFrontovoibombardirButton.UseVisualStyleBackColor = true;
            this.SetFrontovoibombardirButton.Click += new System.EventHandler(this.SetFrontovoibombardirButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(454, 452);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "raketi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(454, 480);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "pylimet";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(284, 453);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(52, 17);
            this.Weight.TabIndex = 11;
            this.Weight.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color";
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(345, 453);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(88, 22);
            this.WeighttextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Color";
            this.label2.Click += new System.EventHandler(this.dopColor_Click);
            // 
            // SetColorButton
            // 
            this.SetColorButton.BackColor = System.Drawing.Color.Red;
            this.SetColorButton.Location = new System.Drawing.Point(345, 491);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(81, 30);
            this.SetColorButton.TabIndex = 15;
            this.SetColorButton.Text = "Color";
            this.SetColorButton.UseVisualStyleBackColor = false;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click_1);
            // 
            // SetdopColorButton
            // 
            this.SetdopColorButton.BackColor = System.Drawing.Color.White;
            this.SetdopColorButton.Location = new System.Drawing.Point(626, 490);
            this.SetdopColorButton.Name = "SetdopColorButton";
            this.SetdopColorButton.Size = new System.Drawing.Size(76, 30);
            this.SetdopColorButton.TabIndex = 16;
            this.SetdopColorButton.Text = "Color";
            this.SetdopColorButton.UseVisualStyleBackColor = false;
            this.SetdopColorButton.Click += new System.EventHandler(this.SetdopColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 585);
            this.Controls.Add(this.SetdopColorButton);
            this.Controls.Add(this.SetColorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeighttextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SetFrontovoibombardirButton);
            this.Controls.Add(this.SetSamoletButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.MaxCountPassengertextBox);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.MaxCountPassenger);
            this.Controls.Add(this.MaxSpeed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MaxSpeed;
        private System.Windows.Forms.Label MaxCountPassenger;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.TextBox MaxCountPassengertextBox;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button SetSamoletButton;
        private System.Windows.Forms.Button SetFrontovoibombardirButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.Button SetdopColorButton;
    }
}

