using System;

namespace BaiThucHanh4
{
    public class Shapes
    {
        public string name;
        public virtual double Area() => 0;
    }

    public class Rectangle : Shapes
    {
        public double width;
        public double height;

        public override double Area() => width * height;
    }

    public class Square : Rectangle
    {
        public Square() { }

        public override double Area()
        {
            height = width; // Ensure width and height are the same for squares
            return base.Area();
        }
    }

    public class Circle : Shapes
    {
        public double radius;

        public override double Area() => Math.Round(Math.PI * radius * radius);
    }

    public class Triangle : Shapes
    {
        public double a;
        public double b;
        public double c;

        public override double Area()
        {
            double p = 0.5 * (a + b + c);
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so luong cac hinh ve: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            Shapes[] shapes = new Shapes[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap vao lua chon hinh ve:\n1 - Hinh chu nhat\n2 - Hinh vuong\n3 - Hinh tron\n4 - Hinh tam giac");
                Console.WriteLine("-------------------------------------------------------------------");


                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Rectangle rec = new Rectangle { name = "Hinh chu nhat" };
                            do
                            {
                                Console.Write("Width: ");
                                rec.width = double.Parse(Console.ReadLine());
                            } while (rec.width <= 0);

                            do
                            {
                                Console.Write("Height: ");
                                rec.height = double.Parse(Console.ReadLine());
                            } while (rec.height <= 0);

                            shapes[i] = rec;
                            break;
                        }
                    case 2:
                        {
                            Square sq = new Square { name = "Hinh vuong" };
                            do
                            {
                                Console.Write("Width: ");
                                sq.width = double.Parse(Console.ReadLine());
                            } while (sq.width <= 0);
                            shapes[i] = sq;
                            break;
                        }
                    case 3:
                        {
                            Circle cir = new Circle { name = "Hinh tron" };
                            do
                            {
                                Console.Write("Radius: ");
                                cir.radius = double.Parse(Console.ReadLine());
                            } while (cir.radius <= 0);
                            shapes[i] = cir;
                            break;
                        }
                    case 4:
                        {
                            Triangle tri = new Triangle { name = "Hinh tam giac" };
                            do
                            {
                                Console.Write("a: ");
                                tri.a = double.Parse(Console.ReadLine());
                            } while (tri.a <= 0);

                            do
                            {
                                Console.Write("b: ");
                                tri.b = double.Parse(Console.ReadLine());
                            } while (tri.b <= 0);

                            do
                            {
                                Console.Write("c: ");
                                tri.c = double.Parse(Console.ReadLine());
                            } while (tri.c <= 0);
                            shapes[i] = tri;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        i--; // Decrement i to retry this iteration
                        continue;
                }
            }

            Array.Sort(shapes, (x, y) => y.Area().CompareTo(x.Area()));

            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Max of area in the set of shapes is:\n\t" + shapes[0].name + "\t" + shapes[0].Area());

            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("List of descending shapes area is: ");
            foreach (Shapes s in shapes)
            {
                Console.WriteLine("\t" + s.name + "\t" + s.Area());
            }

            Console.ReadKey();
        }
    }
}