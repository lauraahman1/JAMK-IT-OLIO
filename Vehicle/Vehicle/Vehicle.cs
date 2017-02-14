using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program Car
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Porcshe", 150);
            Car car2 = new Car("Lada", 80);
            Car car3 = new Car("Lambo", 250);
            Console.WriteLine("Car name is {0} and speed {1}", car1.Name, car1.Speed); // Car name is Porcshe and speed 150
            Console.WriteLine("Car name is {0} and speed {1}", car2.Name, car2.Speed); // Car name is Lada and speed 80 
            Console.WriteLine("Car name is {0} and speed {1}", car3.Name, car3.Speed); // Car name is Lambo and speed 200
        }
    }