using System;
using Generic_List_and_Using_Object.Classes;
namespace Generic_List_and_Using_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car{Brand = "BMW", FuelConsumption = 9, Modal = "X5", TotalDistance=5000},
                new Car{Brand = "MERCEDES", FuelConsumption = 6, Modal = "C200", TotalDistance=5500},
                new Car{Brand = "AUDI", FuelConsumption = 4, Modal = "A6", TotalDistance=9000}
            };

            foreach (Car car in cars)
            {
                Console.WriteLine($"Marka: {car.Brand}, Model: {car.Modal}, 100 km'de yaktığı yakıt: {car.FuelConsumption} L, Toplam yakıt tüketimi: {car.TotalFuelConsumption()}");
            }
        }
    }
}