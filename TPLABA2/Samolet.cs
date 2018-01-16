using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA2
{
    public class Samolet : letniitransport
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 1500)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 750;
                }
            }
        }
        public override int MaxcountVzletMass
        {
            get
            {
                return base.MaxcountVzletMass;
            }
            protected set
            {
                if (value > 0 && value < 150000)
                {
                    base.MaxcountVzletMass = value;
                }
                else
                {
                    base.MaxcountVzletMass = 100000;
                }
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 60000 && value < 120000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 90000;
                }
            }
        }
        public Samolet(int maxSpeed, int maxCountVzletMass, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxcountVzletMass = maxCountVzletMass;
            this.ColorBody = color;
            this.Weight = weight;
            this.countVzletMass = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
        public override void moveSamolet(Graphics g)
        {
            startPosX += (MaxSpeed * 500 / (float)Weight) / (countVzletMass == 0 ? 1 : countVzletMass);
            drawSamolet(g);
        }
        public override void drawSamolet(Graphics g)
        {
            GrajdanSamolet(g);
        }
        protected virtual void GrajdanSamolet(Graphics g)
        {

            //хвост
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, startPosX, startPosY, startPosX + 10, startPosY + 15);
            g.DrawLine(pen, startPosX, startPosY, startPosX, startPosY + 15);
            //тело 
            Brush br = new SolidBrush(ColorBody);
            g.FillRectangle(br, startPosX, startPosY + 15, 85, 15);
            //передняя часть
            g.DrawLine(pen, startPosX + 85, startPosY + 15, startPosX + 95, startPosY + 30);
            g.DrawLine(pen, startPosX + 80, startPosY + 30, startPosX + 95, startPosY + 30);
            //крылья 
            g.DrawLine(pen, startPosX + 45, startPosY - 10, startPosX + 55, startPosY + 15);
            g.DrawLine(pen, startPosX + 45, startPosY - 10, startPosX + 45, startPosY + 15);
            g.DrawLine(pen, startPosX + 45, startPosY + 55, startPosX + 55, startPosY + 30);
            g.DrawLine(pen, startPosX + 45, startPosY + 30, startPosX + 45, startPosY + 55);
        }
    }
}
