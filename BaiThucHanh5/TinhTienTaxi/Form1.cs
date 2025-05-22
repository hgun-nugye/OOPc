using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienTaxi
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void output_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input.Text))
            {
                MessageBox.Show("Vui lòng nhập số km");
                return;
            }
            else
            {
                try
                {
                    double km = double.Parse(input.Text);
                    double total = 0;

                    if (km < 0)
                    {
                        MessageBox.Show("Số km không hợp lệ");
                        return;
                    }
                    else
                    {
                        if (km <= 1)
                        {
                            if (seat7.Checked)
                            {
                                total = 17000;
                            }
                            else if (seat5.Checked)
                            {
                                total = 15000;
                            }
                        }
                        else if (km <= 5)
                        {
                            if (seat7.Checked)
                            {
                                total = 15000 *(km-1)+17000;
                            }
                            else if (seat5.Checked)
                            {
                                total = 13500 *(km-1)+15000;
                            }
                        }
                        else if (km <= 100)
                        {
                            if (seat7.Checked)
                            {
                                total = 12000 *(km-5) + 15000 * 4 + 17000;
                            }
                            else if (seat5.Checked)
                            {
                                total = 11000 *(km-5) + 13500 * 4 + 15000;
                            }
                        }
                        else
                        {
                            if (seat7.Checked)
                            {
                                total = 11000 *(km-100) + 12000 * 95 + 15000 * 4 + 17000;
                            }
                            else if (seat5.Checked)
                            {
                                total = 10000 *(km-100) + 11000 * 95 + 13500 * 4 + 15000;
                            }
                        }
                    }
                    if (discount.Checked)
                    {
                        total = total - (total * 0.05);
                    }
                    output.Text = total.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập số km hợp lệ");
                }
            }
        }

        private void esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toTablePrice_Click(object sender, EventArgs e)
        {
            new TablePrice().Show();
        }
    }
}
