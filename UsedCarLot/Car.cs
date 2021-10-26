using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }


        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }


        List<string> NewCars = new List<string>();
        List<string> UsedCars = new List<string>();


        //Add Car Method

        //List all cars Method

        //Remove a car Method

        public virtual void PrintCar(Car car)
        {
            Console.WriteLine("");
            string response = $"Make: {car.Make}\n";
            response += $"Model: {car.Model}\n";
            response += $"Year: {car.Year}\n";
            response += $"Price: {car.Price}";
            Console.WriteLine(response);
        }
    }
}


