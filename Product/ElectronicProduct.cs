namespace Product
{
	internal class ElectronicProduct : IProduct, IComparable<IProduct>
	{
		private int soLuong;
		public int SoLuong
		{
			get { return soLuong; }
			set
			{
				if (soLuong < 0) throw new ArgumentException("So luong san pham khong nho hon 0");
				else { soLuong = value; }
			}

		}
		private double donGia;
		public double DonGia
		{
			get { return donGia; }
			set
			{
				if (donGia < 0) throw new ArgumentException("Don gia khong nho hon 0");
				else { donGia = value; }
			}
		}

		public double TongTien()
		{
			return soLuong * donGia;
		}
		public string Display()
		{
			return "\tSo luong: " + soLuong + "\t\tDon gia: " + donGia;
		}

		public int CompareTo(IProduct other)
		{
			if (other == null) return 1;
			return this.DonGia.CompareTo(other.DonGia);
		}
	}
}
