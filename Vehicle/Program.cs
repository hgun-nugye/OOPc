namespace VehicleManagement
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int n;
			do
			{
				Console.Write("Nhap vao so luong phuong tien: ");
				n = int.Parse(Console.ReadLine());
			} while (n < 0);

			Vehicle[] vehicles = new Vehicle[n];
			int choice;
			int[] hours = new int[n];
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("\nNhap vao thong tin cac phuong tien:" +
					"\n\tChon 1 neu la Car" +
					"\n\tChon 2 neu la Motocycle");
				while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
				{
					Console.WriteLine("Lua chon khong hop le! Vui long nhap lai!");
				}
				vehicles[i] = new Vehicle();

				if (choice == 1)
				{
					Car car = new Car();

					Console.Write("Nhap vao bien so xe: ");
					car.licensePlate = Console.ReadLine();

					Console.Write("Nhap vao phi dau xe: ");
					car.parkingFeeRate = double.Parse(Console.ReadLine());

					Console.Write("Nhap vao so gio dau xe: ");
					hours[i] = int.Parse(Console.ReadLine());

					Console.Write("Nhap vao so cua xe: ");
					car.numberOfDoors = int.Parse(Console.ReadLine());

					vehicles[i] = car;
				}
				else
				{
					Motocycle moto = new Motocycle();

					Console.Write("Nhap vao bien so xe: ");
					moto.licensePlate = Console.ReadLine();

					Console.Write("Nhap vao phi dau xe: ");
					moto.parkingFeeRate = double.Parse(Console.ReadLine());

					Console.Write("Nhap vao so gio dau xe: ");
					hours[i] = int.Parse(Console.ReadLine());

					Console.Write("Xe co phai la xe the thao khong? ");
					moto.isSportBike = bool.Parse(Console.ReadLine());

					vehicles[i] = moto;
				}
			}

			//in danh sach phuong tien
			Console.WriteLine("\tDANH SACH PHUONG TIEN");
			foreach (var vehicle in vehicles)
			{
				Console.WriteLine(vehicle.DisplayInfo());
			}
			Vehicle[] or_ve= new Vehicle[vehicles.Length];
			or_ve= vehicles;
			//in danh sach phuong tien theo thu tu tang dan phi dau xe 
			Array.Sort(vehicles, (x, y) => x.ParkingFeeRate.CompareTo(y.ParkingFeeRate));
			Console.WriteLine("\n\tDANH SACH TANG DAN PHI DAU XE");
			foreach (var vehicle in vehicles)
			{
				Console.WriteLine(vehicle.DisplayInfo());
			}

			//in tong hi do xe tung phuong tien
			Console.WriteLine("\tTONG PHI DO XE PHUONG TIEN");
			for (int i = 0; i < n; i++)
			{
				if (or_ve[i].GetType() == typeof(Car))
				{
					Console.WriteLine("Car: " + or_ve[i].CalculateParkingFee(hours[i]));
				}
				else if (vehicles[i].GetType() == typeof(Motocycle))
				{
					Console.WriteLine("Motocycle: " + or_ve[i].CalculateParkingFee(hours[i]));

				}
			}

		}
	}
}