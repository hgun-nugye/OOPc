namespace Product
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int n;
			do
			{
				Console.Write("Nhap vao so luong hang hoa trong kho: ");
				n = int.Parse(Console.ReadLine());

			} while (n <= 0);

			IProduct[] products = new IProduct[n];
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"\nChon mat hang can nhap:" +
					$"\n\tChon 1 neu la hang Dien tu" +
					$"\n\tChon 2 neu la hang gia dung");
				Console.Write("Nhap lua chon: ");
				int choice;
				while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
				{
					Console.WriteLine("Lua chon khong hop le!");
				}
				if (choice == 1)
				{
					ElectronicProduct elec = new ElectronicProduct();
					Console.Write("Nhap vao so luong hang hoa: ");
					elec.SoLuong = int.Parse(Console.ReadLine());
					Console.Write("Nhap vao don gia hang hoa: ");
					elec.DonGia = double.Parse(Console.ReadLine());
					products[i] = elec;
					Console.WriteLine();
				}
				else if (choice == 2)
				{

					GroceryProduct gro = new GroceryProduct();
					Console.Write("Nhap vao khoi luong hang hoa: ");
					gro.KhoiLuong = int.Parse(Console.ReadLine());
					Console.Write("Nhap vao don gia hang hoa: ");
					gro.DonGia = double.Parse(Console.ReadLine());
					products[i] = gro;
					Console.WriteLine();

				}
			}

			//In ra danh sach san pham
			Console.WriteLine("\t\tDANH SACH HANG HOA");
			foreach (IProduct product in products)
			{
				if (product == null)
				{
					Console.WriteLine("Product is null.");
					continue;
				}
				if (product.GetType() == typeof(ElectronicProduct))
				{
					Console.WriteLine("Hang dien tu" + product.Display() + "\tTong tien: " + product.TongTien());
				}
				else if (product.GetType() == typeof(GroceryProduct))
				{
					Console.WriteLine("Hang gia dung" + product.Display() + "\tTong tien: " + product.TongTien());

				}
			}

			//Sap xeo danh sach theo thu tu tang dan cua don gia san pham
			products = products.Where(p => p != null).ToArray();
			Array.Sort(products, Comparer<IProduct>.Create((x, y) => x.DonGia.CompareTo(y.DonGia)));
			Console.WriteLine("\n\tDANH SACH HANG HOA TANG DAN THEO DON GIA");
			foreach (IProduct product in products)
			{
				if (product == null)
				{
					Console.WriteLine("Product is null.");
					continue;
				}
				if (product.GetType() == typeof(ElectronicProduct))
				{
					Console.WriteLine("Hang dien tu" + product.Display() + "\tTong tien: " + product.TongTien());
				}
				else if (product.GetType() == typeof(GroceryProduct))
				{
					Console.WriteLine("Hang gia dung" + product.Display() + "\tTong tien: " + product.TongTien());

				}
			}

			//Sap xeo danh sach theo thu tu tang dan cua don gia san pham			
			Console.WriteLine("\n\t\tDANH SACH TONG TIEN MOI LOAI HANG HOA");
			double totalE = 0;
			double totalG = 0;
			foreach (IProduct product in products)
			{
				if (product.GetType() == typeof(ElectronicProduct))
				{
					totalE += product.TongTien();
				}
				else if (product.GetType() == typeof(GroceryProduct))
				{
					totalG += product.TongTien();
				}

			}
			Console.WriteLine("Hang dien tu: " + totalE);
			Console.WriteLine("Hang gia dung: " + totalG);

		}

	}
}
