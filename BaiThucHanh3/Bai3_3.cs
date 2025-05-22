using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh3
{
    public class HinhVe
    {
        public virtual double getArea() { return 0; }
    }

    public class Rectangle : HinhVe
    {
        private int width { get; set; }
        private int height { get; set; }

        public Rectangle(int Width, int Height) { 
            width = Width; height = Height;
        }
        public override double getArea() {
            return width*height;
        }
    }
    public class Square : Rectangle
    {
        private int side { get; set; }

        public Square(int s):base(s,s)
        {
           side = s;
        }
        public override double getArea()
        {
            return side * side;
        }
    }
    public class Circle : HinhVe
    {
        private int radius { get; set; }

        public Circle(int r)
        {
            radius = r;
        }
        public override double getArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao hinh muon tao:" +
                "\n1 - Hinh chu nhat" +
                "\n2 - Hinh vuong" +
                "\n3 - Hinh tron");
            int choice=int.Parse(Console.ReadLine());
            if(choice == 1 )
            {
                Console.WriteLine("Nhap vao chieu dai va rong cua hinh chu nhat: ");
                int w=int.Parse(Console.ReadLine());
                int h=int .Parse(Console.ReadLine());
                HinhVe obj = new Rectangle(w,h);
                Console.WriteLine("Dien tich hinh chu nhat la: " + obj.getArea());
            }
            else if (choice == 2)
            {
                Console.Write("Nhap vao do danh canh hinh vuong: ");
                int s = int.Parse(Console.ReadLine());
                Rectangle obj=new Square(s);
                Console.WriteLine("Dien tich hinh vuong la: " + obj.getArea());
            }
            else if (choice == 3)
            {
                Console.Write("Nhap vao ban kinh hinh tron: ");
                int r = int.Parse(Console.ReadLine());
                HinhVe obj = new Circle(r);
                Console.WriteLine("Dien tich hinh tron la: " + obj.getArea());
            }
            else Console.WriteLine("Nhap vao khong hop le!");


        }
    }
}
