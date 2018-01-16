using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLABA2;

namespace TPLABA3
{
    class Parking
    {
        aerodrom<Itechnica> parking;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        public Parking()
        {
            parking = new aerodrom<Itechnica>(countPlaces, null);
        }

        public int PutSamolet(Itechnica samolet)
        {
            return parking + samolet;
        }
        public Itechnica GetSamolet(int nomer)
        {
            return parking - nomer;
        }
        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var samolet = parking.getObject(i);
                if (samolet != null)
                {
                    samolet.SetPosition(5 + i / 5 * placeSizeWidth, i % 5 * placeSizeHeight + 15);
                    samolet.drawSamolet(g);
                }
            }
        }
        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 140, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
    }
}

