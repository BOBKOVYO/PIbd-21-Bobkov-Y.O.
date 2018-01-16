using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;
using TPLABA2;
using TPLABA5;
using TPLABA7;
using TPLABA8;

namespace TPLABA3
{
    public partial class FormParking : Form
    {
        Parking parking;
        FormSelectSamolet form;
        private Logger log;

        public FormParking()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
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
                    try
                    {
                        Itechnica samolet = parking.GetSamolet(Convert.ToInt32(maskedTextBox1.Text));
                        if (samolet != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBoxTakeSamolet.Width, pictureBoxTakeSamolet.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            samolet.SetPosition(5, 5);
                            samolet.drawSamolet(gr);
                            pictureBoxTakeSamolet.Image = bmp;
                            Draw();
                        }
                    }
                    catch (ParkingIndexOutofRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на уровень ниже Текущий уровень"+parking.getCurrentLevel);
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на уровень выше Текущий уровень" + parking.getCurrentLevel);
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
                try
                {
                    int place = parking.PutSamolet(samolet);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new ParkingnullautoException();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
                parking.Sort();
                Draw();
                MessageBox.Show("Сортировка окончена");           
        }
    }
}
