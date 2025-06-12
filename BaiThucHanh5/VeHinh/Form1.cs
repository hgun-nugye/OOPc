using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VeHinh
{
	public partial class form1 : Form
	{
		int x, y, h, w;
		double shapeArea = 0;
		double largestArea = 0;
		Rectangle largestShape = Rectangle.Empty;
		List<Shape> shapes = new List<Shape>(); // List to store shapes

		public form1()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		// Define a Shape class to hold the rectangle and its type
		class Shape
		{
			public Rectangle Rect { get; set; }
			public string Type { get; set; }

			public Shape(Rectangle rect, string type)
			{
				Rect = rect;
				Type = type;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			using (Pen pen = new Pen(Color.Blue, 2))
			{
				foreach (var shape in shapes)
				{
					if (shape.Type == "Ellipse")
					{
						e.Graphics.DrawEllipse(pen, shape.Rect);
					}
					else if (shape.Type == "Rectangle")
					{
						e.Graphics.DrawRectangle(pen, shape.Rect);
					}
				}
			}
		}

		private void IsMouseUp(object sender, MouseEventArgs e)
		{
			h = e.Y - y;
			w = e.X - x;
			shapeArea = 0;

			if (Elip.Checked)
			{
				shapeArea = (h * w * Math.PI) / 4;
				shapes.Add(new Shape(new Rectangle(x, y, w, h), "Ellipse")); // Store as ellipse
			}
			else if (hcn.Checked)
			{
				shapeArea = h * w;
				shapes.Add(new Shape(new Rectangle(x, y, w, h), "Rectangle")); // Store as rectangle
			}

			if (shapeArea > largestArea)
			{
				largestArea = shapeArea;
				largestShape = new Rectangle(x, y, w, h);
			}

			Invalidate();
		}

		private void IsMouseDown(object sender, MouseEventArgs e)
		{
			x = e.X;
			y = e.Y;
		}

		private void FillLargestShape()
		{
			if (largestShape != Rectangle.Empty)
			{
				using (Graphics g = this.CreateGraphics())
				{
					using (SolidBrush brush = new SolidBrush(Color.Plum))
					{
						if (Elip.Checked)
						{
							g.FillEllipse(brush, largestShape);
							MessageBox.Show("Hình Elip có diện tích lớn nhất.\nDiện tích: " + largestArea.ToString("F2"), "Largest Shape", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else if (hcn.Checked)
						{
							g.FillRectangle(brush, largestShape);
							MessageBox.Show("Hình Chữ nhật có diện tích lớn nhất.\nDiện tích: " + largestArea.ToString("F2"), "Largest Shape", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			FillLargestShape();
		}
	}
}