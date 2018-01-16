using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA2
{
    public abstract class letniitransport : Itechnica
    {
        protected float startPosX;
        protected float startPosY;
        protected int countVzletMass;
        public virtual int MaxcountVzletMass { protected set; get; }
        public virtual int MaxSpeed { protected set; get; }
        public Color ColorBody { protected set; get; }
        public virtual double Weight { protected set; get; }
        public abstract void moveSamolet(Graphics g);
        public abstract void drawSamolet(Graphics g);
        public void SetPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }
        public void loadVzletMass(int count)
        {
            if (countVzletMass + count < MaxcountVzletMass)
            {
                countVzletMass += count;
            }
        }
        public int getVzletMass()
        {
            int count = countVzletMass;
            countVzletMass = 0;
            return count;
        }
        public virtual void setMainColor(Color color)
        {
            ColorBody = color;
        }
    }
}
