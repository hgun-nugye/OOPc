using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_CuoiKy
{
    public class Xe
    {
        private string _tenhang;
        private int _namSX;
        public string tenhang
        {
            get { return _tenhang; }
            set
            {
               if (value.Length <= 5) throw new ArgumentException("Ten hang phai lon hon 5 ky tu!");
                else _tenhang = value;
            }
        }
        public int namSX
        {
            set
            {
                if (value < 1900 || value > 2025)
                    throw new ArgumentException("Nam san xuat phai trong khoang tu 1900 den 2025");
                else _namSX = value;
            }
            get
            {
                return _namSX;
            }
        }
        public const float thueTT = 0.5f;

        public virtual void Nhap()
        {
            Console.WriteLine("\nNhap vao thong tin cua xe: ");
            Console.Write("Nhap vao ten hang xe: ");
            tenhang = Console.ReadLine();
            Console.Write("Nhap vao nam san xuat xe: ");
            namSX=int.Parse(Console.ReadLine());

        }

        public virtual void Xuat()
        {
            Console.WriteLine("\tTen hang: {0}\t\tNam san xuat: {1}", tenhang, namSX);
        }

    }
}
