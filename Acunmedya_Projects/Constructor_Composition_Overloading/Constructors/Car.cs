using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading.Constructors
{
    public class Car
    {
        public CarProps props;
        public double cost;
        public Car(CarProps props, double cost)
        {
            this.props = props;
            this.cost = cost;
        }

        public void writeProps()
        {
            Console.WriteLine($"Arabanın markası {props.brand.brandName}, modeli {props.modal.modal}, kapı sayısı {props.door.doorNumber}, pencere sayısı {props.window.windowNumber}, kasası {props.body.bodyType}, fiyatı {cost} TL'dir.");
        }

    }
}
