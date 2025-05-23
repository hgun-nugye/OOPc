﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HienThiAnh
{
    public partial class imageShow : Form
    {
        public imageShow()
        {
            InitializeComponent();
            picture.Hide();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (picture.BackgroundImage == null) 
            {
                MessageBox.Show("Không có hình ảnh để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                picture.Show(); 
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            picture.Hide();
        }
    }
}
