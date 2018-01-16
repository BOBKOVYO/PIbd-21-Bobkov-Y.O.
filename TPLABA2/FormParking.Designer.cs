namespace TPLABA3
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeSamolet = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeSamolet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonSetSamolet = new System.Windows.Forms.Button();
            this.buttonSetFrontovoibombardir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeSamolet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1031, 640);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // pictureBoxTakeSamolet
            // 
            this.pictureBoxTakeSamolet.Location = new System.Drawing.Point(1037, 503);
            this.pictureBoxTakeSamolet.Name = "pictureBoxTakeSamolet";
            this.pictureBoxTakeSamolet.Size = new System.Drawing.Size(200, 137);
            this.pictureBoxTakeSamolet.TabIndex = 1;
            this.pictureBoxTakeSamolet.TabStop = false;
            this.pictureBoxTakeSamolet.Click += new System.EventHandler(this.pictureBoxTakeSamolet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(1049, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать самолёт";
            // 
            // buttonTakeSamolet
            // 
            this.buttonTakeSamolet.Location = new System.Drawing.Point(1082, 470);
            this.buttonTakeSamolet.Name = "buttonTakeSamolet";
            this.buttonTakeSamolet.Size = new System.Drawing.Size(118, 27);
            this.buttonTakeSamolet.TabIndex = 4;
            this.buttonTakeSamolet.Text = "Забрать";
            this.buttonTakeSamolet.UseVisualStyleBackColor = true;
            this.buttonTakeSamolet.Click += new System.EventHandler(this.buttonTakeSamolet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Место:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(84, 31);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(84, 22);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // buttonSetSamolet
            // 
            this.buttonSetSamolet.Location = new System.Drawing.Point(1058, 12);
            this.buttonSetSamolet.Name = "buttonSetSamolet";
            this.buttonSetSamolet.Size = new System.Drawing.Size(166, 52);
            this.buttonSetSamolet.TabIndex = 3;
            this.buttonSetSamolet.Text = "Посадить самолёт";
            this.buttonSetSamolet.UseVisualStyleBackColor = true;
            this.buttonSetSamolet.Click += new System.EventHandler(this.buttonSetSamolet_Click);
            // 
            // buttonSetFrontovoibombardir
            // 
            this.buttonSetFrontovoibombardir.Location = new System.Drawing.Point(1058, 81);
            this.buttonSetFrontovoibombardir.Name = "buttonSetFrontovoibombardir";
            this.buttonSetFrontovoibombardir.Size = new System.Drawing.Size(166, 53);
            this.buttonSetFrontovoibombardir.TabIndex = 4;
            this.buttonSetFrontovoibombardir.Text = "Посадить бомбардировщик";
            this.buttonSetFrontovoibombardir.UseVisualStyleBackColor = true;
            this.buttonSetFrontovoibombardir.Click += new System.EventHandler(this.buttonSetFrontovoibombardir_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 640);
            this.Controls.Add(this.buttonTakeSamolet);
            this.Controls.Add(this.buttonSetFrontovoibombardir);
            this.Controls.Add(this.buttonSetSamolet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxTakeSamolet);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeSamolet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxTakeSamolet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeSamolet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonSetSamolet;
        private System.Windows.Forms.Button buttonSetFrontovoibombardir;
    }
}

