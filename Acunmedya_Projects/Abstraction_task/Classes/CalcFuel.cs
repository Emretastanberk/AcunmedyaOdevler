using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_task.Interfaces;

namespace Abstraction_task.Classes
{
    internal class CalcFuel : IFuel
    {
        
        public double Calculate()
        {
            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            Porsche porsche = new Porsche();
            double _totalFuel = 0;

            _totalFuel += bmw.whatIsFuel();
            _totalFuel += mercedes.whatIsFuel();
            _totalFuel += porsche.whatIsFuel();
            return _totalFuel;
        }
    }
}
