using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Condition_Assignment.Classes
{
    internal class Person
    {

        public int calcAge(int birthDate)
        {
            return 2025 - birthDate;
        }
        public string ageControl(int age)
        {
            if (age > 0 && age < 18)
            {
                return "Kucuksunuz.";
            }
            else if (age >= 18 && age < 35)
            {
                return "Gencsiniz";
            }
            else if (age >= 35 && age < 55)
            {
                return "Yetiskinsiniz";
            }
            else if (age >= 55 && age < 75)
            {
                return "Yaslisiniz";
            }
            else if (age >= 75 && age < 99)
            {
                return "Cok yaslisiniz";
            }
            else
            {
                return "ya hiç doğmadınızı yada çoktan öldünüz";
            }
        }
    }
}
