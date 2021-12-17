using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashkovaCar
{
    public class AutobusComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Autobus && y is AutobusModern) 
            {
                return 1;
            }
            if (x is AutobusModern && y is Autobus) 
            {
                return -1;
            }
            if (x is Autobus && y is Autobus)
            {
                return ComparerAutobus((Autobus)x, (Autobus)y);
            }
            if (x is AutobusModern && y is AutobusModern) 
            {
                return ComparerAutobusModern((AutobusModern)x, (AutobusModern)y);
            }
            return 0;
        }
        private int ComparerAutobus(Autobus x, Autobus y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerAutobusModern(AutobusModern x, AutobusModern y)
        {
            var res = ComparerAutobus(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.SecondVagon != y.SecondVagon)
            {
                return x.SecondVagon.CompareTo(y.SecondVagon);
            }
            if (x.Garmoshka != y.Garmoshka)
            {
                return x.Garmoshka.CompareTo(y.Garmoshka);
            }
            return 0;
        }
    }
}
