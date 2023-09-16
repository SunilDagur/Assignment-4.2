using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2
{
    using System;

    class Car
    {
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

       
        public string FullCarName
        {
            get
            {
                return $"{Make} {Model} {Year}";
            }
        }

       
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        
        public static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Camry", 2022);
            Console.WriteLine($"Full Car Name: {myCar.FullCarName}");
        }
    }

}
