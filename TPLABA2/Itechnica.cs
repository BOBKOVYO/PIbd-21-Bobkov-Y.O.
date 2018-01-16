using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA2
{
    public interface Itechnica
    {
        void moveSamolet(Graphics g);
        void drawSamolet(Graphics g);
        void SetPosition(int x, int y);
        void loadVzletMass(int count);
        int getVzletMass();
        void setMainColor(Color color);
    }
}
