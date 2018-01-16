namespace TPLABA5
{
    partial class FormSelectSamolet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelfrontovoibombardir = new System.Windows.Forms.Label();
            this.labelSamolet = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelSamolet = new System.Windows.Forms.Panel();
            this.labeldopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxSamolet = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.groupBoxType.SuspendLayout();
            this.panelSamolet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamolet)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelfrontovoibombardir);
            this.groupBoxType.Controls.Add(this.labelSamolet);
            this.groupBoxType.Location = new System.Drawing.Point(40, 56);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(201, 144);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип самолёта";
            // 
            // labelfrontovoibombardir
            // 
            this.labelfrontovoibombardir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelfrontovoibombardir.Location = new System.Drawing.Point(23, 90);
            this.labelfrontovoibombardir.Name = "labelfrontovoibombardir";
            this.labelfrontovoibombardir.Size = new System.Drawing.Size(154, 28);
            this.labelfrontovoibombardir.TabIndex = 1;
            this.labelfrontovoibombardir.Text = "frontovoibombardir";
            this.labelfrontovoibombardir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelfrontovoibombardir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelfrontovoibombardir_MouseDown);
            // 
            // labelSamolet
            // 
            this.labelSamolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSamolet.Location = new System.Drawing.Point(23, 34);
            this.labelSamolet.Name = "labelSamolet";
            this.labelSamolet.Size = new System.Drawing.Size(154, 32);
            this.labelSamolet.TabIndex = 0;
            this.labelSamolet.Text = "Samolet";
            this.labelSamolet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSamolet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSamolet_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(61, 339);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(155, 45);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(115, 423);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 47);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelSamolet
            // 
            this.panelSamolet.AllowDrop = true;
            this.panelSamolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSamolet.Controls.Add(this.labeldopColor);
            this.panelSamolet.Controls.Add(this.labelBaseColor);
            this.panelSamolet.Controls.Add(this.pictureBoxSamolet);
            this.panelSamolet.Location = new System.Drawing.Point(341, 65);
            this.panelSamolet.Name = "panelSamolet";
            this.panelSamolet.Size = new System.Drawing.Size(231, 423);
            this.panelSamolet.TabIndex = 3;
            this.panelSamolet.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelSamolet_DragDrop);
            this.panelSamolet.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelSamolet_DragEnter);    
            // 
            // labeldopColor
            // 
            this.labeldopColor.AllowDrop = true;
            this.labeldopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldopColor.Location = new System.Drawing.Point(12, 337);
            this.labeldopColor.Name = "labeldopColor";
            this.labeldopColor.Size = new System.Drawing.Size(207, 40);
            this.labeldopColor.TabIndex = 2;
            this.labeldopColor.Text = "Доп. цвет";
            this.labeldopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeldopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labeldopColor_DragDrop);
            this.labeldopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(14, 279);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(205, 37);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxSamolet
            // 
            this.pictureBoxSamolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSamolet.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxSamolet.Name = "pictureBoxSamolet";
            this.pictureBoxSamolet.Size = new System.Drawing.Size(206, 218);
            this.pictureBoxSamolet.TabIndex = 0;
            this.pictureBoxSamolet.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelColor);
            this.groupBoxColor.Location = new System.Drawing.Point(627, 60);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(208, 428);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGold.Location = new System.Drawing.Point(121, 324);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(58, 56);
            this.panelGold.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(7, 324);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(58, 56);
            this.panelGray.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelYellow.Location = new System.Drawing.Point(121, 210);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(58, 56);
            this.panelYellow.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(7, 210);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(58, 56);
            this.panelRed.TabIndex = 3;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(121, 106);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(58, 56);
            this.panelBlue.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(7, 106);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(58, 56);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(121, 10);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(58, 56);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(7, 10);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(58, 56);
            this.panelBlack.TabIndex = 0;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelGold);
            this.panelColor.Controls.Add(this.panelGray);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelWhite);
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Location = new System.Drawing.Point(10, 20);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(188, 389);
            this.panelColor.TabIndex = 4;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FormSelectSamolet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 529);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelSamolet);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxType);
            this.Name = "FormSelectSamolet";
            this.Text = "FormSelectCar";
            this.groupBoxType.ResumeLayout(false);
            this.panelSamolet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamolet)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelfrontovoibombardir;
        private System.Windows.Forms.Label labelSamolet;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelSamolet;
        private System.Windows.Forms.Label labeldopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.PictureBox pictureBoxSamolet;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelColor;
    }
}