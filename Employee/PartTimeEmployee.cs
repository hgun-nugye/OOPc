namespace Employee
{
	internal class PartTimeEmployee : Employee
	{
		public override void DisplayInfor()
		{
			Console.Write("\tParttime");
			base.DisplayInfor();
		}
	}
}
