using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiThucHanh3
{
    public class NhanVien
    {
        private String hoTen { get; set; }
        private DateTime ngSinh { get; set; }
        private int luong { get; set; }

        public NhanVien()
        {
            hoTen= null; ;
            ngSinh= DateTime.Now ;
            luong= 0 ;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap vao ho va ten cua nhan vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap vao ngay sinh cua nhan vien: ");
            ngSinh = DateTime.Parse(Console.ReadLine());

        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho va ten: {0}\tNgay sinh: {1}", hoTen, ngSinh.ToShortDateString());          

        }
        public virtual int Luong() { return 0; }
    }

    public class NhanVienSX: NhanVien
    {
        private int luongCB { get; set; }
        private int soSP { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap vao luong co ban: ");
            luongCB=int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so san pham: ");
            soSP=int .Parse(Console.ReadLine());
        }
        public override int Luong() {
            return luongCB + soSP * 5000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong co ban: {0} \tSo san pham: {1}", luongCB, soSP);
            Console.WriteLine("Luong cua nhan vien san xuat nay la: {0}",Luong());
        }

    }
    public class NhanVienVP : NhanVien
    {
        private int soNgayLam { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap vao so ngay lam viec: ");
            soNgayLam = int.Parse(Console.ReadLine());
        }
        public override int Luong()
        {
            return soNgayLam * 1000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So ngay lam: " + soNgayLam);
            Console.WriteLine("Luong cua nhan vien van phong nay la: {0}", Luong());
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so luong nhan vien:");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0);
            NhanVien[] nv=new NhanVien[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("\nNhap thong tin cho nhan vien thu " +(i+1));               
                Console.WriteLine("Chon loai nhan vien:\n1 - Nhan vien san xuat\n2 - Nhan vien van phong");
                int choice= int.Parse(Console.ReadLine());  
                if(choice==1)
                {
                    nv[i] = new NhanVienSX();
                    nv[i].Nhap();
                }
                else if(choice==2)
                {
                    nv[i] = new NhanVienVP();
                    nv[i].Nhap();
                }
                else
                    Console.WriteLine("Lua chon khong hop le!");
            }

            Console.WriteLine("\n\t\tDANH SACH NHAN VIEN:");
            Console.WriteLine("*****************************************************************");
            foreach (NhanVien em in nv)
            {
                em.Xuat();
                Console.WriteLine("----------------------------------------------------\n");
            }

            Console.WriteLine("\tDanh sach nhan vien xep theo luong giam dan:");
            Console.WriteLine("*****************************************************************");
            Array.Sort(nv, (x,y)=> y.Luong().CompareTo(x.Luong()));
            foreach (NhanVien em in nv)
            {
                em.Xuat();
                Console.WriteLine("---------------------------------------------------\n");
            }
        }
    }
}
