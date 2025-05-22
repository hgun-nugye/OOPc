namespace Employee
{
	internal class Employee : IEmployee
	{
		public string ID { get; set; }
		public string name { get; set; }
		private double salary;
		public double Salary
		{
			get { return salary; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Luong khong duoc nho hon 0");
				}
				salary = value;
			}
		}

		public virtual void DisplayInfor()
		{
			Console.WriteLine($"\tID: {ID}\t Name: {name}\t\tSalary: {salary}");
		}
	}
}
