using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class AAuthor : Attribute
    {

        public string Name { get; }
        public AAuthor(string name)
        {
            this.Name = name;
        }
    }
}
