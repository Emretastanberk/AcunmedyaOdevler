using System;
using Abstraction_task.Classes;

namespace Abstraction_task
{
    class Program
    {
        static void Main(string[] args)
        {

            Bmw bmw = new Bmw();
            bmw.fastCar("bmw");
            bmw.flyingCar("bmw");
            bmw.swimmingCar("bmw");

            Mercedes mercedes = new Mercedes();
            mercedes.flyingCar("mercedes");
            mercedes.swimmingCar("mercedes");

            Porsche porsche = new Porsche();
            porsche.flyingCar("porsche");

        }

    }

}

