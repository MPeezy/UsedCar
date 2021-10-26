using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UsedCarLot
{
    class CarLot
    {
 
        public UsedCarLot()
        {
            //create 3 new cars make model year price
       
            Cars.Add("Ford", "Taurus", 2021, 20000.00);
            Cars.Add("Chevy", "Tahoe", 2020, 18000.00);
            Cars.Add("Honda", "Civic", 2021, 15000.00);

             public List<Car> Cars { get; set; } = new List<Car>();

        //create 3 used cars make model year price mileage

            public List<Car> UsedCars { get; set; } = new List<Car>();
            UsedCars.Add("Cadillac", "Escalade", 2000, 10000.00, 70000);
            UsedCars.Add("Ford", "Explorer", 2004, 12000.00, 100000);
            UsedCars.Add("Chevy", "Malibu", 2006, 8000.00, 20000);

        }


    }
}
