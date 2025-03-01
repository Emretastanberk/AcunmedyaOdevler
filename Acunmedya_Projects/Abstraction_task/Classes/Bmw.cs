﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_task.Abstractions;
using Abstraction_task.Interfaces;

namespace Abstraction_task.Classes
{
    internal class Bmw : ABS_Car, IFast, ISwim, IFly
    {
    public void fastCar(string brand)
    {
        Console.WriteLine($"{brand} çok hızlı.");
    }

    public void swimmingCar(string brand)
    {
        Console.WriteLine($"{brand} yüzüyor.");
    }

    public void flyingCar(string brand)
    {
        Console.WriteLine($"{brand} uçuyor.");

    }

    public override double whatIsFuel()
    {
        return 80.0;
    }
    }
}
