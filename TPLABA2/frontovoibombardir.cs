using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA2
{
    public class frontovoibombardir : Samolet
    {
        private bool raketi;
        private bool pylimet;
        private Color dopColor;
        public frontovoibombardir(int maxSpeed, int maxCountVzletMass, double weight, Color color, bool raketi, bool pylimet, Color dopColor) : base(maxSpeed, maxCountVzletMass, weight, color)
        {
            this.raketi = raketi;
            this.pylimet = pylimet;
            this.dopColor = dopColor;
        }
        public frontovoibombardir(string info): base (info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxcountVzletMass = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                raketi = Convert.ToBoolean(strs[4]);
                pylimet= Convert.ToBoolean(strs[5]);
                dopColor= Color.FromName(strs[6]); ;
            }
        }
        protected override void GrajdanSamolet(Graphics g)
        {
            if (raketi)
            {
                Brush br = new SolidBrush(dopColor);
                g.FillRectangle(br, startPosX + 40, startPosY + 7, 15, 5);
                g.FillRectangle(br, startPosX + 40, startPosY + 37, 15, 5);
                br = new SolidBrush(dopColor);
                g.FillEllipse(br, startPosX + 53, startPosY + 6, 5, 6);
                g.FillEllipse(br, startPosX + 53, startPosY + 36, 5, 6);
            }
            if (pylimet)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawLine(pen, startPosX + 75, startPosY + 30, startPosX + 75, startPosY + 35);
                g.DrawLine(pen, startPosX + 65, startPosY + 35, startPosX + 85, startPosY + 35);
            }
            base.GrajdanSamolet(g);
        }
        public void setDopColor(Color color)
        {
            dopColor = color;
        }
        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxcountVzletMass + ";" + Weight + ";" + ColorBody.Name+";" + raketi + ";" + pylimet + ";" + dopColor.Name ;
        }
    }
}
