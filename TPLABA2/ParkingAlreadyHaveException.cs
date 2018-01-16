using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA8
{
    class ParkingAlreadyHaveException: Exception
    {
        public ParkingAlreadyHaveException() :
            base("На аэродроме уже есть такой самолёт"){ }
    }
}
