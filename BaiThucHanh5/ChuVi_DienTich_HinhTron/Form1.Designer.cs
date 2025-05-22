namespace ChuVi_DienTich_HinhTron
{
    partial class CSR
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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.perimeter = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.esc = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập bán kính hình tròn:";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.BackColor = System.Drawing.SystemColors.Window;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(342, 12);
            this.input.MinimumSize = new System.Drawing.Size(170, 40);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(214, 56);
            this.input.TabIndex = 1;
            // 
            // perimeter
            // 
            this.perimeter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.perimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perimeter.Location = new System.Drawing.Point(30, 89);
            this.perimeter.Name = "perimeter";
            this.perimeter.Size = new System.Drawing.Size(125, 57);
            this.perimeter.TabIndex = 2;
            this.perimeter.Text = "Chu Vi";
            this.perimeter.UseVisualStyleBackColor = false;
            this.perimeter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.perimeter_MouseClick);
            // 
            // area
            // 
            this.area.BackColor = System.Drawing.SystemColors.ControlLight;
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(224, 89);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(143, 57);
            this.area.TabIndex = 3;
            this.area.Text = "Diện Tích";
            this.area.UseVisualStyleBackColor = false;
            this.area.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area_MouseClick);
            // 
            // esc
            // 
            this.esc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.esc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esc.Location = new System.Drawing.Point(431, 89);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(125, 57);
            this.esc.TabIndex = 4;
            this.esc.Text = "Thoát";
            this.esc.UseVisualStyleBackColor = false;
            this.esc.Click += new System.EventHandler(this.esc_Click);
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(40, 183);
            this.output.Margin = new System.Windows.Forms.Padding(10);
            this.output.MaximumSize = new System.Drawing.Size(520, 150);
            this.output.MinimumSize = new System.Drawing.Size(520, 150);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(520, 150);
            this.output.TabIndex = 5;
            // 
            // CSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.area);
            this.Controls.Add(this.perimeter);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "CSR";
            this.Text = "Tính chu vi, diện tích hình tròn";
            this.Load += new System.EventHandler(this.CSR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button perimeter;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button esc;
        private System.Windows.Forms.TextBox output;
    }
}

