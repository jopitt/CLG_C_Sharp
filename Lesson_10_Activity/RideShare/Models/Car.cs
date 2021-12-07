using System;

namespace RideShare.Models
{
    public class Car : Vehicle
	{
        public Car(double distanceAwayInKm)
        {
            DistanceAwayInKm = distanceAwayInKm;
        }
	}
}