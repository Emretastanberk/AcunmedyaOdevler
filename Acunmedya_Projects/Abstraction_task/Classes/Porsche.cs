using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_task.Interfaces;

namespace Abstraction_task.Classes
{
    internal class Porsche: Car, IFly
    {
        public void flyingCar(string brand)
        {
            Console.WriteLine($"{brand} uçuyor.");
        }
    }
}
