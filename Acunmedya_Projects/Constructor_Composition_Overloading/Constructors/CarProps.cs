using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading.Constructors
{
    public class CarProps
    {
        public Brand brand;
        public Modal modal;
        public Door door;
        public Window window;
        public CarBody body;
        
        public CarProps(Brand brand, Modal modal, Door door, Window window, CarBody carBody) 
        {
            this.brand = brand;
            this.modal = modal;
            this.door = door;
            this.window = window;
            this.body = carBody;
        }
    }
}
