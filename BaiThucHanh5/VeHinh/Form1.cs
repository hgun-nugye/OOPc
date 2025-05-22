using System.Drawing;
using System.Windows.Forms;
using System;

namespace VeHinh
{
    public partial class form1 : Form
    {
        int x, y, h, w; 
        Pen p = new Pen(Color.Blue, 2);
        double shapeArea = 0;
        double largestArea = 0;
        Rectangle largestShape = Rectangle.Empty; 

        private void IsMouseUp(object sender, MouseEventArgs e)
        {
            h = e.Y - y; 
            w = e.X - x;
            shapeArea = 0; 

            if (Elip.Checked)
            {
                shapeArea = (h * w * Math.PI) / 4;
            }
            else if (hcn.Checked)
            {
                shapeArea = h * w;
            }

           
            if (shapeArea > largestArea)
            {
                largestArea = shapeArea;
                largestShape = new Rectangle(x, y, w, h);
            }

            Graphics g = this.CreateGraphics();
            if (Elip.Checked)
            {
                g.DrawEllipse(p, new Rectangle(x, y, w, h));
            }
            else if (hcn.Checked)
            {
                g.DrawRectangle(p, new Rectangle(x, y, w, h));
            }

            //MessageBox.Show("Diện tích = " + shapeArea.ToString());
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
                    using (SolidBrush brush = new SolidBrush(Color.Yellow)) 
                    {
                        if (Elip.Checked) 
                        {
                            g.FillEllipse(brush, largestShape);
                        }
                        else if (hcn.Checked) 
                        {
                            g.FillRectangle(brush, largestShape);
                        }
                    }
                }
            }
        }

        public form1()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e) // Add a finish button to fill the largest shape
        {
            FillLargestShape();
        }
    }
}