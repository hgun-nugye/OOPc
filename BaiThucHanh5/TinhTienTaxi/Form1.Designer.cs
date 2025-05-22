namespace TinhTienTaxi
{
    partial class form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toTablePrice = new System.Windows.Forms.Label();
            this.texthead = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.seat7 = new System.Windows.Forms.RadioButton();
            this.seat5 = new System.Windows.Forms.RadioButton();
            this.discount = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toTablePrice
            // 
            this.toTablePrice.AutoSize = true;
            this.toTablePrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toTablePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toTablePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTablePrice.Location = new System.Drawing.Point(18, 21);
            this.toTablePrice.Name = "toTablePrice";
            this.toTablePrice.Size = new System.Drawing.Size(147, 25);
            this.toTablePrice.TabIndex = 0;
            this.toTablePrice.Text = "Xem Bảng giá";
            this.toTablePrice.Click += new System.EventHandler(this.toTablePrice_Click);
            // 
            // texthead
            // 
            this.texthead.AutoSize = true;
            this.texthead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthead.Location = new System.Drawing.Point(18, 70);
            this.texthead.Name = "texthead";
            this.texthead.Size = new System.Drawing.Size(258, 29);
            this.texthead.TabIndex = 1;
            this.texthead.Text = "Quãng đường đi (km)";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.Menu;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(302, 63);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(211, 36);
            this.input.TabIndex = 2;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seat7
            // 
            this.seat7.AutoSize = true;
            this.seat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat7.Location = new System.Drawing.Point(39, 149);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(90, 29);
            this.seat7.TabIndex = 3;
            this.seat7.TabStop = true;
            this.seat7.Text = "7 chỗ";
            this.seat7.UseVisualStyleBackColor = true;
            // 
            // seat5
            // 
            this.seat5.AutoSize = true;
            this.seat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat5.Location = new System.Drawing.Point(166, 149);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(90, 29);
            this.seat5.TabIndex = 4;
            this.seat5.TabStop = true;
            this.seat5.Text = "5 chỗ";
            this.seat5.UseVisualStyleBackColor = true;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(341, 149);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(123, 29);
            this.discount.TabIndex = 5;
            this.discount.Text = "Giảm giá";
            this.discount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số tiền thanh toán VND:";
            // 
            // output
            // 
            this.output.AcceptsTab = true;
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.BackColor = System.Drawing.SystemColors.Control;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(29, 276);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(344, 67);
            this.output.TabIndex = 7;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // esc
            // 
            this.esc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.esc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esc.Location = new System.Drawing.Point(409, 292);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(104, 51);
            this.esc.TabIndex = 8;
            this.esc.Text = "Thoát";
            this.esc.UseVisualStyleBackColor = false;
            this.esc.Click += new System.EventHandler(this.esc_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 379);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.seat5);
            this.Controls.Add(this.seat7);
            this.Controls.Add(this.input);
            this.Controls.Add(this.texthead);
            this.Controls.Add(this.toTablePrice);
            this.Name = "form";
            this.Text = "Tính tiền Taxi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toTablePrice;
        private System.Windows.Forms.Label texthead;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.RadioButton seat7;
        private System.Windows.Forms.RadioButton seat5;
        private System.Windows.Forms.CheckBox discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button esc;
    }
}

