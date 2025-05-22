using System;

namespace KT_CuoiKy
{
    public class XeCon : Xe
    {
        private int _giaban;
        public int giaban
        {
            get { return _giaban; }
            set
            {
                if (value <= 0) throw new ArgumentException("Gia ban phai lon hon 0");
                else _giaban = value;
            }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap vao gia ban xe: ");
            giaban = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\tGia ban: " + giaban);
            Console.WriteLine("\tThue: "+Thue());
        }

        public double Thue()
        {
            return thueTT * giaban;
        }


    }
}
