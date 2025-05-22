using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh3
{
    public class Xe
    {
        public String bienSo;
        public int namSX;
        public float gia;
        public Xe()
        {
            bienSo = null;
            namSX = 0;
            gia = 0;
        }
        public Xe(string bienSo, int namSX, float gia)
        {
            this.bienSo = bienSo;
            this.namSX = namSX;
            this.gia = gia;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap vap bien so xe: ");
            bienSo = Console.ReadLine();
            Console.Write("Nhap vap nam san xuat xe: ");
            namSX = int.Parse(Console.ReadLine());
            Console.Write("Nhap vap gia cua xe: ");
            gia = float.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Xe co bien so {0}, san xuat nam {1} co gia la {2}", bienSo, namSX, gia);

        }
    }
    public class XeCon : Xe
    {
        public int soChoNgoi;
        public string loaiXe;
        public XeCon() : base()
        {
            soChoNgoi = 0;
            loaiXe = null;
        }
        public XeCon(string bienSo, int namSX, float gia, int soChoNgoi, string loaiXe) : base(bienSo, namSX, gia)
        {
            this.soChoNgoi = soChoNgoi;
            this.loaiXe = loaiXe;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap vao so cho ngoi: ");
            soChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao loai xe: ");
            loaiXe = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Xe co {0} cho ngoi, loai xe la {1}\n", soChoNgoi, loaiXe);

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            //nhập số lượng xe con
            do
            {
                Console.Write("Nhap vao so luong xe con:");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            XeCon[] xeCons = new XeCon[n];

            //nhập thông tin các xe 
            for (int i = 0; i < n; i++)
            {
                xeCons[i] = new XeCon();
                Console.WriteLine("\nNhap vao xe con thu " + (i + 1));
                xeCons[i].Nhap();
            }

            Console.WriteLine("--------------------------------------");
            //xuất thông tin các xe
            Console.WriteLine("\nThong tin cac xe la:");
            foreach (XeCon xeCon in xeCons)
            {
                xeCon.Xuat();
            }

            Console.WriteLine("--------------------------------------");

            //tìm xe có giá cao nhất 
            Array.Sort(xeCons, (x, y) => y.gia.CompareTo(x.gia));
            Console.WriteLine("\nXe co gia cao nhat la:");
            xeCons[0].Xuat();

            Console.WriteLine("--------------------------------------");

            //tìm xe có giá thấp nhất 
            Console.WriteLine("\nXe co gia thap nhat la:");
            xeCons[n - 1].Xuat();

            Console.WriteLine("--------------------------------------");

            //in ra các xe có biển số chứa dữ liệu nhập 
            Console.Write("\nNhap vao 2 chu so cua bien so: ");
            String twoDigit = Console.ReadLine();
            foreach (XeCon xeCon in xeCons)
            {
                if (xeCon.bienSo.StartsWith(twoDigit))
                {
                    xeCon.Xuat();
                }
            }

            Console.WriteLine("--------------------------------------");

            //sắp xếp và in các xe tăng dần theo năm sản xuất
            Array.Sort(xeCons, (x, y) => x.namSX.CompareTo(y.namSX));
            Console.WriteLine("\nCac xe xep theo thu tu tang dan cua nam san xuat la:");
            foreach (XeCon xeCon in xeCons)
            {
                xeCon.Xuat();
            }
        }
    }
}
