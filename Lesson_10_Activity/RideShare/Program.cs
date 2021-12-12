using System;
using System.Collections.Generic;
using RideShare.Models;

namespace RideShare.Models
{
    class Program
    {
        static void Main(string[] args)
        {
			var randomGenerator = new Random();
			var randomDistance = randomGenerator.NextDouble();
			var randomWithin5km = Math.Round(5 * randomDistance, 1);
		
			var car1 = new Car(4.5);

			var car2 = new Car(1.2);

			var car3 = new Car(randomWithin5km);

			var luxuryCar1 = new LuxuryCar(0.6);

			var luxuryCar2 = new LuxuryCar(0.2);

			var luxuryCar3 = new LuxuryCar(randomWithin5km);

			var extraLargeCar1 = new ExtraLargeCar(3.0);

			var extraLargeCar2 = new ExtraLargeCar(randomWithin5km);

			var extraLargeCar3 = new ExtraLargeCar(randomWithin5km);


			var vehicles = new List<Vehicle> { car1, car2, car3, luxuryCar1, luxuryCar2, luxuryCar3, extraLargeCar1, extraLargeCar2, extraLargeCar3 };

			foreach (var vehicle in vehicles)
			{
				vehicle.ReportDistance();
			}
			Console.WriteLine();

			while(vehicles.Count > 0)
			{
				Console.WriteLine();
				Console.WriteLine("Press any key to report distance of vehicle (to exit, press x):");
				var input = Console.ReadLine().ToLower();

				if(input == "x")
				{
					Console.WriteLine("You have exited the application.");
					break;
				}
				
				var randomVehicle = randomGenerator.Next(0, vehicles.Count);

				var selectedVehicle = vehicles[randomVehicle];
				vehicles.RemoveAt(randomVehicle);

				selectedVehicle.ReportDistance();

				if(vehicles.Count == 0)
				{
					Console.WriteLine();
					Console.WriteLine("There are no more vehicles within your location.");
				}
			}
        }
	}
}

		