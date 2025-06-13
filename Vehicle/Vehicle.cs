namespace VehicleManagement
{
	public class Vehicle: IVehicle
	{
		public string LicensePlate;
		public string licensePlate
		{
			get { return LicensePlate; }
			set
			{
				if (value.Length < 8) throw new ArgumentException("Do dai bien so xe khong hop le");
				else LicensePlate = value;
			}
		}

		public double ParkingFeeRate;
		public double parkingFeeRate
		{
			get { return ParkingFeeRate; }
			set
			{
				if (value < 0) throw new ArgumentException("Phi do xe khong duoc nho hon 0");
				else ParkingFeeRate = value;
			}
		}
		public virtual string DisplayInfo()
		{
			return "\tBien so xe: " + licensePlate + "\tPhi do xe: " + parkingFeeRate + "\n";
		}
		public double CalculateParkingFee(int hours)
		{
			return hours * parkingFeeRate;
		}
	}
}
