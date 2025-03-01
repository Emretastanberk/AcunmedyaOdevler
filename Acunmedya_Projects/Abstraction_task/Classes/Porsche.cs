using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_task.Abstractions;
using Abstraction_task.Interfaces;

namespace Abstraction_task.Classes
{
    internal class Porsche: ABS_Car, IFly
    {
        public void flyingCar(string brand)
        {
            Console.WriteLine($"{brand} uçuyor.");
        }

        public override double whatIsFuel()
        {
            return 60.0;
        }
    }
}
