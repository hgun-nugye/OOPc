namespace Employee
{
	public class Program
	{
		static void Main(string[] args)
		{
			int n;

			do
			{
				Console.Write("Nhap vao so luong nhan vien: ");
				n = int.Parse(Console.ReadLine());
			} while (n <= 0);
			Employee[] employees = new Employee[n];

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("\nNhap vao thong tin nhan vien thu " + (i + 1));
				Console.WriteLine("\n.................................................................");
				Console.WriteLine("Nhan vien Full time hay Part time?" +
					"\n1. Full time" +
					"\n2. Part time");
				int choice = int.Parse(Console.ReadLine());

				if (choice == 1)
				{
					Console.WriteLine("Full time");
					employees[i] = new FullTimeEmployee();
				}
				else if (choice == 2)
				{
					Console.WriteLine("Part time");
					employees[i] = new PartTimeEmployee();
				}
				else
				{
					throw new ArgumentException("Khong co loai nhan vien nay!");
				}

				Console.Write("Nhap vao ID nhan vien: ");
				employees[i].ID = (Console.ReadLine());

				Console.Write("\nNhap vao ten nhan vien: ");
				employees[i].name = Console.ReadLine();

				Console.Write("\nNhap vao luong nhan vien: ");
				employees[i].Salary = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("-------------------------------------------------------------------------------");

			Console.WriteLine("\t\tDANH SACH NHAN VIEN");
			foreach (Employee e in employees)
			{
				e.DisplayInfor();
			}

			Console.WriteLine("-------------------------------------------------------------------------------");

			Array.Sort(employees, (x, y) => x.ID.CompareTo(y.ID));
			Console.WriteLine("\t\tDANH SACH NHAN VIEN CO ID TANG DAN");
			foreach (Employee e in employees)
			{
				e.DisplayInfor();
			}

			Console.WriteLine("-------------------------------------------------------------------------------");

			Array.Sort(employees, (x, y) => x.name.CompareTo(y.name));
			Console.WriteLine("\t\tDANH SACH NHAN VIEN CO TEN TANG DAN");
			foreach (Employee e in employees)
			{
				e.DisplayInfor();
			}

			Console.WriteLine("-------------------------------------------------------------------------------");

			Array.Sort(employees, (x, y) => x.Salary.CompareTo(y.Salary));
			Console.WriteLine("\t\tDANH SACH NHAN VIEN CO LUONG TANG DAN");
			foreach (Employee e in employees)
			{
				e.DisplayInfor();
			}

		}
	}
}