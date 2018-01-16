using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLABA2;

namespace TPLABA3
{
    class aerodrom<T> where T : Itechnica
    {
        private T[] places;
        private T defaultValue;
        public aerodrom(int sizes, T defVal)
        {
            defaultValue = defVal;
            places = new T[sizes];
            for (int i = 0; i < places.Length; i++)
            {
                places[i] = defaultValue;
            }
        }
        public static int operator +(aerodrom<T> p, T samolet)
        {
            for(int i = 0; i < p.places.Length; i++)
            {
               if (p.CheckFreePlace(i))
               {
                   p.places[i] = samolet;
                   return i;
               }
            }
            return -1;            
        }
        public static T operator -(aerodrom<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T samolet = p.places[index];
                p.places[index] = p.defaultValue;
                return samolet;
            }
            return p.defaultValue;
        }
        private bool CheckFreePlace(int index)
        {
             if (index < 0 || index > places.Length)
             {
                 return false;
             }
             if (places[index] == null)
             {
                 return true;
             }
             if (places[index].Equals(defaultValue))
                 {
                 return true;
                 }
             return false;
        }
        public T getObject(int ind)
        {
            if(ind>-1 && ind < places.Length)
            {
                return places[ind];
            }
            return defaultValue;
        }
        
    }
}
