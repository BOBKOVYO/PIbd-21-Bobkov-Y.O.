using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPLABA2
{
    public partial class Form1 : Form
    {

        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountVzletMass;
        int weight;

        private Itechnica inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Yellow;
            maxSpeed = 1000;
            maxCountVzletMass = 4000;
            weight = 70000;
            SetColorButton.BackColor = color;
            SetdopColorButton.BackColor = dopColor;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveSamolet(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dopColor_Click(object sender, EventArgs e)
        {

        }
        private bool checkFields()
        {
            if (!int.TryParse(MaxSpeedTextBox.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(MaxCountPassengertextBox.Text, out maxCountVzletMass))
            {
                return false;
            }
            if (!int.TryParse(WeighttextBox.Text, out weight))
            {
                return false;
            }
            return true;
        }
        private void buttonSetSportSedan_Click(object sender, EventArgs e)
        {
            inter = new frontovoibombardir(500, 2000, 65000, Color.Black, true, true, Color.Yellow);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawSamolet(gr);
            pictureBox1.Image = bmp;
        }
        private void SetColorButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SetdopColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                SetdopColorButton.BackColor = dopColor;
            }
        }

        private void SetSamoletButton_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Samolet(maxSpeed, maxCountVzletMass, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawSamolet(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void SetFrontovoibombardirButton_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new frontovoibombardir(maxSpeed, maxCountVzletMass, weight, color, checkBox1.Checked, checkBox3.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawSamolet(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void SetColorButton_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                SetColorButton.BackColor = color;
            }
        }
    }
    }
