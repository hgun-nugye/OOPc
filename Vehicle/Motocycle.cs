namespace VehicleManagement
{
	internal class Motocycle : Vehicle, IVehicle
	{
		private bool IsSportBike;
		public bool isSportBike { get; set; }

		public override string DisplayInfo()
		{
			if (isSportBike) return "Motocycle\tSport Bike" + base.DisplayInfo();
			return "Motocycle\t\t" + base.DisplayInfo();
		}
		public double CalculateParkingFee(int hours)
		{
			return hours * parkingFeeRate;
		}

	}
}
