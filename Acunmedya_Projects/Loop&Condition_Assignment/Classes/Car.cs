using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Condition_Assignment.Classes
{
    public class Car
    {

        public string Brand { get; set; }
        public int GetCarAge(int model_year)
        {
            return 2025 - model_year;
        }

        public string carStat(int car_age)
        {
            if (car_age >= 0 && car_age < 10)
                return "Arabanız yeni";
            else if (car_age >= 10 && car_age < 20)
                return "Servise götürmeniz gerekebilir";
            else if (car_age >= 20 && car_age < 30)
                return "Arabanız hurdaya çıkabilir";
            else
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
    }
}
