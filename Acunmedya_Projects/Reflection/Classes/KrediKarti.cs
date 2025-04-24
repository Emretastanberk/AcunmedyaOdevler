using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reflection.Interfaces;

namespace Reflection.Classes
{
    public class KrediKarti: IOdemeYontemi
    {
        public string Ode(decimal tutar) => $"Kredi kartı ile {tutar:C} ödendi.";
    }
}
