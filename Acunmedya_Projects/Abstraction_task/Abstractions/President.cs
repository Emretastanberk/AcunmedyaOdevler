using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_task.Abstractions
{
    internal class President:Worker
    {
        public override double whatIsSalary()
        {
            return 80000.0;
        }
    }
}
