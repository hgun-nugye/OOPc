using Shapes;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<IShape> shapes = new List<IShape>
		{
			new Rectangle(5, 10),
			new Circle(4)
		};

		foreach (IShape shape in shapes)
		{
			shape.Display(); // Gọi phương thức của từng lớp một cách đa hình
		}
	}
}