using System;

namespace RideShare.Models
{
    public class Car : Vehicle
	{
        public Car(double distanceAwayInKm)
        {
            DistanceAwayInKm = distanceAwayInKm;
        }

        public override void ReportDistance()
		{
			Console.WriteLine($"There is a car {DistanceAwayInKm}km away.");
		}
	}
}