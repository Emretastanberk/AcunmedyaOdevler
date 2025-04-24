using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Interfaces
{
    public interface IOdemeYontemi
    {
        //Belirli bir tutarı ödeyip açıklama döndermesi için string
        string Ode(decimal tutar);
    }
}
