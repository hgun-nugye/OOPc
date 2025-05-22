using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PTBac2
{
    public partial class PTB2 : Form
    {
        
        public PTB2()
        {
            InitializeComponent();
        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void result_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(inputa.Text) || !int.TryParse(inputa.Text, out int a))
                {
                    throw new Exception("Vui lòng nhập hệ số a");
                }
                else if (string.IsNullOrWhiteSpace(inputa.Text) || !int.TryParse(inputb.Text, out int b))
                {
                    throw new Exception("Vui lòng nhập hệ số b");
                }
                else if (string.IsNullOrWhiteSpace(inputc.Text) || !int.TryParse(inputc.Text, out int c))
                {
                    throw new Exception("Vui lòng nhập hệ số c");
                }
                else if (sender == result)
                {
                    if (a == 0)
                    {
                        if (b == 0)
                        {
                            if (c == 0)
                            {
                                output.Text = "Phuong trinh vo so nghiem.";
                            }
                            else
                            {
                                output.Text = "Phuong trinh vo nghiem.";
                            }

                        }
                        else
                        {
                            double kq = Math.Round((double)c / -b, 4);
                            output.Text = "Phuong trinh co duy nhat nghiem :" + kq;
                        }
                    }
                    else
                    {
                        double delta = 1.0*b * b - 4 * a * c;
                        if (delta < 0)
                        {
                            output.Text = "Phuong trinh vo so nghiem.";
                        }
                        else if (delta == 0)
                        {
                            double x = -1.0*b / 2 / a;
                            output.Text = "Phuong trinh co nghiem kep la: " + x;
                        }
                        else
                        {
                            double x1 = Math.Round(((-b - Math.Sqrt(delta)) / 2 / a), 4);
                            double x2 = Math.Round(((-b + Math.Sqrt(delta)) / 2 / a), 4);
                            output.Text = "Phuong trinh co 2 nghiem phan biet la: x1=" + x1 + "; x2=" + x2;
                        }
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
