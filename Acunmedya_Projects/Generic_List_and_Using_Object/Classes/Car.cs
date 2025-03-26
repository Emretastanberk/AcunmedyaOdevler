using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_and_Using_Object.Classes
{
    public class Car
    {
        public string Brand;
        public string Modal;
        public double FuelConsumption;
        public double TotalDistance;

        public double TotalFuelConsumption()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }
    }
}
