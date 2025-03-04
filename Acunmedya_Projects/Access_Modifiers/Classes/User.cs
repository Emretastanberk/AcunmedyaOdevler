using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers.Classes
{
    internal class User
    {

        private string nameSurname;
        private int age;
        public string eMail;

        public string NameSurname
        {
            get { return nameSurname;}
            set { nameSurname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void showInfos()
        {
            Console.WriteLine($"Name and surname: {nameSurname} Age:{age}");
        }
    }
}
