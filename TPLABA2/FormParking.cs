using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPLABA2;
using TPLABA5;

namespace TPLABA3
{
    public partial class FormParking : Form
    {
        Parking parking;
        FormSelectSamolet form;


        public FormParking()
        {
            InitializeComponent();
            parking = new Parking(5);
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonSetSamolet_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var samolet = new Samolet(100, 4, 1000, dialog.Color);
                int place = parking.PutSamolet(samolet);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }

        }
        private void buttonSetFrontovoibombardir_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var samolet = new frontovoibombardir(100, 4, 1000, dialog.Color, true, true, dialogDop.Color);
                    int place = parking.PutSamolet(samolet);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void buttonTakeSamolet_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    var samolet = parking.GetSamolet(Convert.ToInt32(maskedTextBox1.Text));
                    Bitmap bmp = new Bitmap(pictureBoxTakeSamolet.Width, pictureBoxTakeSamolet.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    samolet.SetPosition(5, 5);
                    samolet.drawSamolet(gr);
                    pictureBoxTakeSamolet.Image = bmp;
                    Draw();
                }
                else
                {
                    MessageBox.Show("Извинте, на этом месте нет самолёта");
                }
            }
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void buttonSetSamolet_Click_1(object sender, EventArgs e)
        {
            form = new FormSelectSamolet();
            form.AddEvent(AddSamolet);
            form.Show();
        }
        private void AddSamolet(Itechnica samolet)
        {
            if (samolet != null)
            {
                int place = parking.PutSamolet(samolet);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Самолёт не удалось поставить ");
                }
            }
        }
    }
}
