using System;
using System.Collections.Generic;

namespace KT_CuoiKy
{
     class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so luong xe con: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 2 || n >= 100);

            XeCon[] xeCons=new XeCon[n];
            for (int i = 0; i < n; i++)
            {
                xeCons[i]=new XeCon();
                xeCons[i].Nhap();
            }

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("\t\tDANH SACH XE CON VUA NHAP");
            foreach (XeCon i in xeCons)
            {
                i.Xuat();
                Console.WriteLine("\t...............................................");
            }

            Array.Sort(xeCons, (x, y) => (x.giaban).CompareTo(y.giaban));
            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("\t\tXE CON CO GIA THAP NHAT");
            xeCons[0].Xuat();

            XeCon[] xeConsNew = new XeCon[n];
            int j = 0;
            for (int i=0; i<n; i++)
            {
                DateTime dt = DateTime.Now;
                if ((dt.Year - xeCons[i].namSX) <= 10)
                {
                    xeConsNew[j++] = xeCons[i];
                }
            }

            Console.WriteLine("\n----------------------------------------------------------------");
            if (j == 0) Console.WriteLine("Danh sach xe sau xu ly rong!");
            else
            {
                Console.WriteLine("\tDANH SACH XE CON SAU XU LY:");
                for (int i = 0; i < j; i++)
                {
                    xeConsNew[i].Xuat();
                    Console.WriteLine("\t...............................................");

                }
            }
            Console.ReadKey();

        }
    }
}
