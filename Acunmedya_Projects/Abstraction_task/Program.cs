using System;
using Abstraction_task.Abstractions;
using Abstraction_task.Classes;
using Abstraction_task.Interfaces;

namespace Abstraction_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ödev-1");
            Bmw bmw = new Bmw();
            bmw.fastCar("bmw");
            bmw.flyingCar("bmw");
            bmw.swimmingCar("bmw");

            Mercedes mercedes = new Mercedes();
            mercedes.flyingCar("mercedes");
            mercedes.swimmingCar("mercedes");

            Porsche porsche = new Porsche();
            porsche.flyingCar("porsche");


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ödev-2");

            President president = new President();
            Manager manager = new Manager();
            Programmer programmer = new Programmer();
            Intern intern = new Intern();

            double totalSalary = 0.0;

            totalSalary += president.whatIsSalary();
            totalSalary += manager.whatIsSalary();
            totalSalary += programmer.whatIsSalary();
            totalSalary += intern.whatIsSalary();

            Console.WriteLine("Total Salary: " + totalSalary);


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ödev-3");

            IFuel fuel = new CalcFuel();

            Console.WriteLine("Toplam tüketilen yakıt "+fuel.Calculate() + " L");











            Console.Read();



        }

    }

}

