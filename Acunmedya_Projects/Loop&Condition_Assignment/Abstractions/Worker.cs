using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopCondition_Assignment.Abstractions
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Job { get; set; }
        public string Department { get; set; }
        public abstract double whatIsSalary();

    }
}
