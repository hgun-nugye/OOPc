namespace VehicleManagement
{
	internal interface IVehicle
	{
		double CalculateParkingFee(int hours);
		string DisplayInfo();
	}
}
