namespace VehicleManagement
{
	internal class Car : Vehicle, IVehicle
	{
		private int NumberOfDoors;
		public int numberOfDoors
		{
			get { return NumberOfDoors; }
			set
			{
				if (value < 2)
				{
					throw new ArgumentException("So cua phai lon hon hoac bang 2");
				}
				else NumberOfDoors = value;
			}
		}
		public override string DisplayInfo()
		{
			return "Car\t\tSo cua: " + numberOfDoors + base.DisplayInfo();
		}
		public double CalculateParkingFee(int hours)
		{
			return hours * parkingFeeRate;
		}
	}
}
