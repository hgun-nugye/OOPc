namespace Product
{
	internal class GroceryProduct : IProduct, IComparable<IProduct>
	{
		public double khoiLuong;
		public double KhoiLuong
		{
			get { return khoiLuong; }
			set
			{
				if (khoiLuong < 0) throw new ArgumentException("Khoi luong san pham khong nho hon 0");
				else { khoiLuong = value; }
			}

		}
		public double donGia;
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
			return khoiLuong * donGia;
		}
		public string Display()
		{
			return "\tKhoi luong: " + khoiLuong + "\t\tDon gia: " + donGia;
		}

		public int CompareTo(IProduct other)
		{
			if (other == null) return 1;
			return this.DonGia.CompareTo(other.DonGia);
		}
	}
}
