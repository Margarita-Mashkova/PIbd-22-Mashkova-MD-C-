using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashkovaCar
{
    public class BusStationOverflowException : Exception
    {
        public BusStationOverflowException() : base("На автовокзале нет свободных мест"){}
    }
}
