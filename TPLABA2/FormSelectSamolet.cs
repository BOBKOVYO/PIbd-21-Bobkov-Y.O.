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
using TPLABA3;


namespace TPLABA5
{
    public partial class FormSelectSamolet : Form
    {
        Itechnica samolet = null;
        public Itechnica getSamolet { get { return samolet; } }
        private void DrawSamolet()
        {
            if (samolet != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxSamolet.Width, pictureBoxSamolet.Height);
                Graphics gr = Graphics.FromImage(bmp);
                samolet.SetPosition(5, 5);
                samolet.drawSamolet(gr);
                pictureBoxSamolet.Image = bmp;
            }
        }
        private event myDel eventAddSamolet;
        public void AddEvent(myDel ev)
        {
            if (eventAddSamolet == null)
            {
                eventAddSamolet = new myDel(ev);
            }
            else
            {
                eventAddSamolet += ev;
            }
        }

        public FormSelectSamolet()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
       
        private void labelSamolet_MouseDown(object sender, MouseEventArgs e)
        {
            labelSamolet.DoDragDrop(labelSamolet.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelfrontovoibombardir_MouseDown(object sender, MouseEventArgs e)
        {
            labelfrontovoibombardir.DoDragDrop(labelfrontovoibombardir.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelSamolet_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void panelSamolet_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Samolet":
                    samolet = new Samolet(1000, 4000, 70000, Color.White);
                    break;
                case "frontovoibombardir":
                    samolet = new frontovoibombardir(1000, 4000, 70000, Color.White, true, true, Color.Black);
                    break;
            }
            DrawSamolet();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }      
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (samolet != null)
            {
                samolet.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawSamolet();
            }
        }
        private void labeldopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (samolet != null)
            {
                if (samolet is frontovoibombardir)
                {
                    (samolet as frontovoibombardir).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawSamolet();
                }
            }
        }    
        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            if (eventAddSamolet != null)
            {
                eventAddSamolet(samolet);
            }
            Close();
        }
    }
}
