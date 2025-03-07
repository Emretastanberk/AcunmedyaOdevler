using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoopCondition_Assignment.Abstractions;
using LoopCondition_Assignment.Interfaces;

namespace LoopCondition_Assignment.Classes
{
    internal class Mercedes : ABS_Car
    {
        
        public override double whatIsFuel()
        {
            return 70.0;
        }
    }
}
