using System.Drawing;
using System.Windows.Forms;
using System;

namespace DrawShapes
{
    public partial class frmDrawShapes : Form
    {
        int x, y, h, w; // (x,y): coordinates of the top-left corner, h: height, w: width
        Pen p = new Pen(Color.Blue, 2);
        double shapeArea = 0;
        double largestArea = 0;
        Rectangle largestShape = Rectangle.Empty; // Store the largest shape

        private void IsMouseUp(object sender, MouseEventArgs e)
        {
            h = e.Y - y; // Calculate height
            w = e.X - x; // Calculate width
            shapeArea = 0; // Reset shape area for each shape

            if (radioCircle.Checked)
            {
                shapeArea = (h * w * Math.PI) / 4; // Area of the circle
            }
            else if (radioRectangle.Checked)
            {
                shapeArea = h * w; // Area of the rectangle
            }

            // Check if this shape is the largest
            if (shapeArea > largestArea)
            {
                largestArea = shapeArea;
                largestShape = new Rectangle(x, y, w, h); // Store the largest shape
            }

            // Draw the shape without filling it yet
            Graphics g = this.CreateGraphics();
            if (radioCircle.Checked)
            {
                g.DrawEllipse(p, new Rectangle(x, y, w, h));
            }
            else if (radioRectangle.Checked)
            {
                g.DrawRectangle(p, new Rectangle(x, y, w, h));
            }

            MessageBox.Show("Diện tích = " + shapeArea.ToString());
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
                    using (SolidBrush brush = new SolidBrush(Color.Yellow)) // Fill color for the largest shape
                    {
                        if (radioCircle.Checked) // Check if the largest shape is a circle
                        {
                            g.FillEllipse(brush, largestShape);
                        }
                        else if (radioRectangle.Checked) // Check if the largest shape is a rectangle
                        {
                            g.FillRectangle(brush, largestShape);
                        }
                    }
                }
            }
        }

        public frmDrawShapes()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e) // Add a finish button to fill the largest shape
        {
            FillLargestShape();
        }
    }
}