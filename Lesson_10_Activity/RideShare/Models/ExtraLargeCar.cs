using System;

namespace RideShare.Models
{
    public class ExtraLargeCar : Vehicle
	{
        public ExtraLargeCar(double distanceAwayInKm)
        {
            DistanceAwayInKm = distanceAwayInKm;
        }

        public override void ReportDistance()
		{
			Console.WriteLine($"There is an extra large car {DistanceAwayInKm}km away.");
		}
	}
}