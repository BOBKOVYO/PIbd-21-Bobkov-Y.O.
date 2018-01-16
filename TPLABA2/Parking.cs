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
        List<aerodrom<Itechnica>> parkingStages;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        int currentLevel;
        public int getCurrentLevel { get { return currentLevel; } }
        public Parking(int countStages)
        {
            parkingStages = new List<aerodrom<Itechnica>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                parkingStages.Add(new aerodrom<Itechnica>(countStages, null));
            }
        }

        public int PutSamolet(Itechnica samolet)
        {
            return parkingStages[currentLevel] + samolet;
        }
        public Itechnica GetSamolet(int nomer)
        {
            return parkingStages[currentLevel] - nomer;
        }
        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var samolet = parkingStages[currentLevel][i];
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
        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }
        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }
    }
}

