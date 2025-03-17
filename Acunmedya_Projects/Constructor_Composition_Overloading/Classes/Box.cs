using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading.Classes
{
    public class Box<T>
    {

        private T content;

        public void Add(T data)
        {
            this.content = data;
        }

        public T Take()
        {
            return content;
        }     

        //Artık bu sınıfı istediğimiz herhangi bir veri türüyle kullanabiliriz.
    }
}
