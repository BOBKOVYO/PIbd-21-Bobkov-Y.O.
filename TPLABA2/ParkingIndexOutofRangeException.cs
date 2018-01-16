using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA7
{
    class ParkingIndexOutofRangeException : Exception
    {
        public ParkingIndexOutofRangeException() :
            base("На аэродроме нет самолёта в данном ангаре"){ }
    }
}
