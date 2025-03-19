using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading.Constructors
{
    public class Car
    {
        public Brand brand;
        public CarBody body;
        public Modal modal;
        public Door door;
        public Window window;
        public double cost;
        public Car(Brand brand,CarBody body,Modal modal,Door door,Window window, double cost)
        {
            this.brand = brand;
            this.body = body;
            this.modal = modal;
            this.door = door;
            this.window = window;
            this.cost = cost;
        }

        public void writeProps()
        {
            Console.WriteLine($"Arabanın markası {brand.brandName}, modeli {modal.modal}, kapı sayısı {door.doorNumber}, pencere sayısı {window.windowNumber}, kasası {body.bodyType}, fiyatı {cost} TL'dir.");
        }

    }
}
