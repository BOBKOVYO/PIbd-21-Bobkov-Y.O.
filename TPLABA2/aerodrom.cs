using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLABA2;
using TPLABA7;
using TPLABA8;

namespace TPLABA3
{
    class aerodrom<T> : IEnumerator<T>, IEnumerable<T>, IComparable<aerodrom<T>>
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;
        private int currentIndex;

        public aerodrom(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size * 4;
        }
        public static int operator +(aerodrom<T> p, T samolet)
        {
            var isfrontovoibombardir = samolet is frontovoibombardir;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (samolet.GetType() == p.places[i].GetType())
                {
                    if (isfrontovoibombardir)
                    {
                        if ((samolet as frontovoibombardir).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((samolet as Samolet).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, samolet);
                return index;
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
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {

        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(aerodrom<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is Samolet && other.places[thisKeys[i]] is frontovoibombardir)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is frontovoibombardir && other.places[thisKeys[i]] is Samolet)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Samolet && other.places[thisKeys[i]] is Samolet)
                    {
                        return (this.places[thisKeys[i]] is Samolet).CompareTo(other.places[thisKeys[i]] is Samolet);
                    }
                    if (this.places[thisKeys[i]] is frontovoibombardir && other.places[thisKeys[i]] is frontovoibombardir)
                    {
                        return (this.places[thisKeys[i]] is frontovoibombardir).CompareTo(other.places[thisKeys[i]] is frontovoibombardir);
                    }
                }
            }
            return 0;
        }
    }
}
