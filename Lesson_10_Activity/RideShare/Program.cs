using System;
using System.Collections.Generic;
using RideShare.Models;

namespace RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
			var car1 = new Car(4.5);
			
			var car2 = new Car(1.2);

			var luxuryCar1 = new LuxuryCar(0.6);

			var luxuryCar2 = new LuxuryCar(0.2);
						
			var extraLargeCar1 = new ExtraLargeCar(3.0);

			
			var vehicles = new List<Vehicle> { car1, car2, luxuryCar1, luxuryCar2, extraLargeCar1 };
			
			foreach (var vehicle in vehicles)
			{
				vehicle.ReportDistance();
			}			
        }
	}
}

		