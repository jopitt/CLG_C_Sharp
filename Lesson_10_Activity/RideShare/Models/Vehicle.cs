using System;
using System.Collections.Generic;

namespace RideShare.Models
{
	public class Vehicle
	{
		internal double DistanceAwayInKm { get; set; }
		public virtual void ReportDistance()
		{
			Console.WriteLine($"There is a vehicle {DistanceAwayInKm}km away.");
		}
	}	
}