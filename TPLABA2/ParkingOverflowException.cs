using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA7
{
    class ParkingOverflowException: Exception
    {
        public ParkingOverflowException():
            base("На аэродроме нет свободных ангаров"){}
    }
}
