namespace Employee
{
	internal class FullTimeEmployee : Employee, IEmployee
	{
		public override void DisplayInfor()
		{
			Console.Write("\tFulltime");
			base.DisplayInfor();
		}
	}
}
