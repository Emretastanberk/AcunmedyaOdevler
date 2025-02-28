using System;
using System.Runtime.ConstrainedExecution;



namespace Inheritance_work
{
    class Program
    {
        static void Main(string[] args)
        {

          

            Mercedes mercedes = new Mercedes();
            mercedes.GetCarInfos("Mercedes", "Manual");

            Porsche porsche = new Porsche();
            porsche.GetCarInfos("Porche", "Automatic");

            Togg togg = new Togg();
            togg.GetCarInfos("Togg", "automatic");

            Bmw bmw = new Bmw();
            bmw.GetCarInfos("Bmw","Manual");

            Audi audi = new Audi();
            audi.GetCarInfos("Audi", "automatic");

            Toyota toyota = new Toyota();
            toyota.GetCarInfos("Toyota", "Manual");

            

        }

        public class Car
        {
            
            public void GetCarInfos(string brand, string transmission)
            {
                Console.WriteLine($"{brand} ---> {transmission}");
            }


        }

        public class Mercedes : Car
        {

        }

        public class Porsche : Car
        {

        }

        public class Togg : Car
        {

        }

        public class Toyota : Car
        {

        }

        public class Audi : Car
        {

        }

        public class Bmw : Car
        {

        }
    }
}