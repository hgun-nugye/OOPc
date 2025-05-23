namespace Shapes
{
	class Rectangle : IShape
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public Rectangle(double width, double height)
		{
			Width = width;
			Height = height;
		}

		public double Area()
		{
			return Width * Height;
		}

		public void Display()
		{
			Console.WriteLine($"Hình chữ nhật: {Width} x {Height}, Diện tích = {Area()}");
		}
	}

	class Circle : IShape
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double Area()
		{
			return Math.PI * Radius * Radius;
		}

		public void Display()
		{
			Console.WriteLine($"Hình tròn: Bán kính = {Radius}, Diện tích = {Area():F2}");
		}
	}
}
