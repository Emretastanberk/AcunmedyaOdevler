using System;
using Constructor_Composition_Overloading.Classes;
using Constructor_Composition_Overloading.Constructors;

namespace Constructor_Composition_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task-1 : C#’ta Composition Kullanarak Araç Oluşturma
            Console.WriteLine("Task-1 : C#’ta Composition Kullanarak Araç Oluşturma\n");
            Brand brand = new Brand("BMW");
            Modal modal = new Modal("X5");
            Door doorNumber = new Door(4);
            Window windowNumber = new Window(4);
            CarBody body = new CarBody("Sedan");
            CarProps props = new CarProps(brand, modal, doorNumber, windowNumber, body);
            Car bmw = new Car(props, 2000000);

            bmw.writeProps();
            Console.WriteLine("---------------------------------------");
            //Task-2 : Method Overloading ile Matematik Sınıfı
            Console.WriteLine("\nTask-2 : Method Overloading ile Matematik Sınıfı\n");

            MyMath add = new MyMath();
            MyMath product = new MyMath();
            double total1 = add.Add(5.4, 2);
            int total2 = add.Add(5, 2, 8);
            double product1 = product.Product(5.9, 2.5);
            int product2 = product.Product(5,2,8);

            Console.WriteLine($"Birinci toplam(double): {total1}\nİkinci toplam(int): {total2}\n");
            Console.WriteLine($"Birinci çarpım(double): {product1}\nİkinci çarpım(int): {product2}");


            Console.WriteLine("---------------------------------------");
            //Task-4 : Generic sınıf ve metotlarla esnek programlama nasıl yapılır?
            Console.WriteLine("\nTask-4 : Generic sınıf ve metotlarla esnek programlama nasıl yapılır?\n");
            //Classes klasöründeki Box classını kontrol edin.
            //Örnek string ile kullanma:
            Box<string> _string = new Box<string>();
            _string.Add("Emre");
            string message = _string.Take();
            Console.WriteLine(message);
            //Örnek int ile kullanma:
            Box<int> _int = new Box<int>();
            _int.Add(19);
            int result = _int.Take();
            Console.WriteLine(result);
         
           
        }
        

    }
}