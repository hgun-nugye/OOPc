using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanh3
{
    public class Printer
    {
        public string nhaSx { get; set; }
        public int gia
        {
            get { return gia; }
            set
            {
                if (value < 0) throw new ArgumentException("Gia khong the nho hon 0");
                else gia = value;
            }
        }
        public Printer() { }
        public Printer(string nhaSx, int gia)
        {
            this.nhaSx = nhaSx;
            this.gia = gia;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap vao ten nha san xuat: ");
            nhaSx = Console.ReadLine();
            Console.Write("Nhap vao gia may in: ");
            gia = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Nha san xuat: {0}\t\tGia: {1}", nhaSx, gia);
        }
    }
    public class LaserPrinter : Printer
    {
        public String doPhanGiai { get; set; }
        public LaserPrinter() { }
        public LaserPrinter(string doPhanGiai)
        {
            this.doPhanGiai = doPhanGiai;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap vao do phan giai cua may: ");
            doPhanGiai = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Do phan giai cua may la: " + doPhanGiai);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so luong may in: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0);
            List<Printer> list = new List<Printer>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap vao thong tin may in thu " + (i + 1));
                Printer p = new LaserPrinter();
                p.Nhap();
                list.Add(p);
            }

            Console.WriteLine("\n\t\tDANH SACH MAY IN");
            Console.WriteLine("*************************************************************");
            foreach (Printer p in list)
            {
                p.Xuat();
                Console.WriteLine("............................................................");
            }

            var newlist = list.OrderByDescending(x => x.gia).ToList();
            Console.WriteLine("\n\tGIA CAO NHAT VA THAP NHAT CUA MAY IN");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("May in co gia cao nhat la: ");
            newlist[0].Xuat();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("May in co gia thap nhat la: ");
            newlist[n - 1].Xuat();

            Console.WriteLine("------------------------------------------------------------");

            Console.Write("Nhap vao ten hang may in can loc:");
            string brand = Console.ReadLine();
            Console.WriteLine("\n\tDANH SACH DA LOC THEO TEN HANG '{0}'", brand);
            Console.WriteLine("--------------------------------------------------------------");
            foreach (Printer p in list)
            {
                if (p.nhaSx.Equals(brand))
                {
                    p.Xuat();
                    Console.WriteLine(".............................................................");

                }
            }

            Console.WriteLine("\n\t\tDANH SACH GIA TANG DAN");
            Console.WriteLine("------------------------------------------------------------");
            newlist.Reverse();
            foreach (Printer p in newlist)
            {
                p.Xuat();
                Console.WriteLine("...........................................................");
            }
        }
    }
}
