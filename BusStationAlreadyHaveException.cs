using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashkovaCar
{
    /// Класс-ошибка "Если на автовокзале уже есть автобус с такими жехарактеристиками"
    public class BusStationAlreadyHaveException : Exception
    {
        public BusStationAlreadyHaveException() : base("На автовокзале уже есть такой автобус") { }
    }
}
