using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA7
{
    class ParkingnullautoException : Exception
    {
        public ParkingnullautoException(): base ("Вы не добавили самолёт"){}
    }
}
