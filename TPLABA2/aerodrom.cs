using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLABA2;
using TPLABA7;

namespace TPLABA3
{
    class aerodrom<T> where T : Itechnica
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;
        public aerodrom(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size*4;
        }
        public static int operator +(aerodrom<T> p, T samolet)
        {
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, samolet);
                    return i;
                }
            }
            p.places.Add(p.places.Count, samolet);
            return p.places.Count - 1;
        }
        public static T operator -(aerodrom<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T samolet = p.places[index];
                p.places.Remove(index);
                return samolet;
            }
            throw new ParkingIndexOutofRangeException();
        }
        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }
        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
    }
}
