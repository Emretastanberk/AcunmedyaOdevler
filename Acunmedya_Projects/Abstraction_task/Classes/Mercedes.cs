﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_task.Interfaces;

namespace Abstraction_task.Classes
{
    internal class Mercedes : Car, ISwim, IFly
    {
        public void swimmingCar(string brand)
        {
            Console.WriteLine($"{brand} yüzüyor.");
        }

        public void flyingCar(string brand)
        {
            Console.WriteLine($"{brand} uçuyor.");
        }
    }
}
