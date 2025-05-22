using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuVi_DienTich_HinhTron
{
    public partial class CSR : Form
    {
        public CSR()
        {
            InitializeComponent();

        }

        private void perimeter_MouseClick(object sender, MouseEventArgs e) {
            try
            {
                if (string.IsNullOrWhiteSpace(input.Text))
                {
                    throw new Exception("Vui lòng nhập bán kính hình tròn");
                }
                else if (sender == perimeter)
                {
                    double r = double.Parse(input.Text);
                    double cv = Math.PI * 2 * r;
                    cv=Math.Round(cv, 2);
                    output.Text = "Diện tích hình tròn là: " + cv.ToString();
                }
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
}

        private void area_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input.Text))
                {
                    throw new Exception("Vui lòng nhập bán kính hình tròn");
                }
                else if (sender == area)
                {
                    double r = double.Parse(input.Text);
                    double dt = Math.PI * r * r;
                    dt = Math.Round(dt, 2);
                    output.Text = "Diện tích hình tròn là: " + dt.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void esc_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void CSR_Load(object sender, EventArgs e)
        {

        }
    }
}
