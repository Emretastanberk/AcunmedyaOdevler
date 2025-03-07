using System;
using Loop_Condition_Assignment.Classes;
using LoopCondition_Assignment.Abstractions;
using LoopCondition_Assignment.Classes;

namespace LoopCondition_Assignment{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK-1");
            Console.Write("Enter the your birthdate: ");
            int birthdate = Convert.ToInt32(Console.ReadLine());
            Person agePerson = new Person();
            int age = agePerson.calcAge(birthdate);
            Person personA = new Person();
            string agecontrol = personA.ageControl(age);
            Console.WriteLine($"You are age {age} ----> {agecontrol}");

            Console.WriteLine("---------------------------------");
            Console.WriteLine("TASK-2");

            Car carAge = new Car();
            Console.Write("Enter the your car's model year: ");
            int model_year = int.Parse(Console.ReadLine());
            int car_age = carAge.GetCarAge(model_year);
            Car carStat = new Car();
            string car_stat = carStat.carStat(car_age);
            Console.WriteLine(car_age + " ----> " + car_stat);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("TASK-3");
            //While Loop: Önce koşulu kontrol eder. Eğer koşul doğruysa döngü çalışır.
            //Sonsuz döngüye girmemesi için kuşulun bir yerde false olması gerekir.
            Console.WriteLine("While ile birden ona kadar yazdırma");
            int w = 1;
            while (w <= 10)
            {
                Console.WriteLine(w);
                w++;
            }

            Console.WriteLine("----");
            Console.WriteLine("do While ile birden ona kadar yazdırma");
            //Do-While: İlk önce kod içeriğini çalıştırır.Ardından koşulu kontrol eder True değer dönerse döngü çalışmaya devam eder.
            //Koşul en başta false değer dönderse bile kod en az bir kere çalışır. 
            int dw = 1;
            do
            {
                Console.WriteLine(dw);
                dw++;

            } while (dw <= 10);
            Console.WriteLine("----");
            Console.WriteLine("For ile birden ona kadar yazdırma");

            for (int f = 1; f <= 10; f++)
            {
                Console.WriteLine(f);
            }


            Console.WriteLine("---------------------------------");
            Console.WriteLine("TASK-4");

            President prs = new President()
            {
                Name = "Emre",
                SurName = "Taştanberk",
                Department = " Computer Developer",
                Job = "President"
            };

            Manager mng = new Manager()
            {
                Name = "Ali",
                SurName = "Yanar",
                Department = " Computer Developer",
                Job = "Manager"
            };
            Programmer prog = new Programmer()
            {
                Name = "Hüseyin",
                SurName = "Kırkgeçit",
                Department = " Computer Programmer",
                Job = "Programmer"
            };
            Intern intern = new Intern()
            {
                Name = "İsmail",
                SurName = "Yıldız",
                Department = "Computer Programmer",
                Job = "Intern"
            };


            Worker[] workers = { prs, mng, prog, intern };

            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.SurName} -- {worker.Department} -- {worker.Job} -- {worker.whatIsSalary()}TL.");
            }

            double total_salary = 0;
            foreach (var worker_salary in workers)
            {
                total_salary += worker_salary.whatIsSalary();
            }
            Console.WriteLine("Total salary: " + total_salary);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("TASK-5");

            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            Porsche porsche = new Porsche();

            ABS_Car[] cars = { bmw, mercedes, porsche };

            double total_fuel = 0;

            foreach (var car_fuel in cars)
            {
                total_fuel += car_fuel.whatIsFuel();
            }

            Console.WriteLine("Total fuel: " + total_fuel +" L");

            Console.Read();

        }
    }
}

 