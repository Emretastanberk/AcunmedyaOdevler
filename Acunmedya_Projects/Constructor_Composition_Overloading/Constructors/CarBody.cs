using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading.Constructors
{
    public class CarBody
    {
        public string bodyType;
        public CarBody(string bodyType)
        {
            this.bodyType = bodyType;
        }
    }
}
