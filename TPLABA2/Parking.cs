using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" + parkingStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in parkingStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var samolet = level[i];
                            if (samolet != null)
                            {
                                if (samolet.GetType().Name == "Samolet")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Samolet:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (samolet.GetType().Name == "frontovoibombardir")
                                {
                                    info = new UTF8Encoding(true).GetBytes("frontovoibombardir:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(samolet.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<aerodrom<Itechnica>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        parkingStages.Add(new aerodrom<Itechnica>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "Samolet")
                    {
                        Itechnica samolet = new Samolet(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + samolet;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "frontovoibombardir")
                    {
                        Itechnica samolet = new frontovoibombardir(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + samolet;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}

