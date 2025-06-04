namespace VeHinh
{
    partial class form1
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
			this.shape = new System.Windows.Forms.GroupBox();
			this.hcn = new System.Windows.Forms.RadioButton();
			this.Elip = new System.Windows.Forms.RadioButton();
			this.check = new System.Windows.Forms.Button();
			this.shape.SuspendLayout();
			this.SuspendLayout();
			// 
			// shape
			// 
			this.shape.Controls.Add(this.hcn);
			this.shape.Controls.Add(this.Elip);
			this.shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shape.Location = new System.Drawing.Point(748, 20);
			this.shape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.shape.Name = "shape";
			this.shape.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.shape.Size = new System.Drawing.Size(162, 97);
			this.shape.TabIndex = 0;
			this.shape.TabStop = false;
			this.shape.Text = "Vẽ hình";
			// 
			// hcn
			// 
			this.hcn.AutoSize = true;
			this.hcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hcn.Location = new System.Drawing.Point(21, 55);
			this.hcn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.hcn.Name = "hcn";
			this.hcn.Size = new System.Drawing.Size(134, 24);
			this.hcn.TabIndex = 1;
			this.hcn.TabStop = true;
			this.hcn.Text = "Hình chữ nhật";
			this.hcn.UseVisualStyleBackColor = true;
			// 
			// Elip
			// 
			this.Elip.AutoSize = true;
			this.Elip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Elip.Location = new System.Drawing.Point(21, 27);
			this.Elip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Elip.Name = "Elip";
			this.Elip.Size = new System.Drawing.Size(58, 24);
			this.Elip.TabIndex = 0;
			this.Elip.TabStop = true;
			this.Elip.Text = "Elip";
			this.Elip.UseVisualStyleBackColor = true;
			// 
			// check
			// 
			this.check.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.check.Location = new System.Drawing.Point(748, 136);
			this.check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.check.Name = "check";
			this.check.Size = new System.Drawing.Size(123, 39);
			this.check.TabIndex = 1;
			this.check.Text = "CHECK";
			this.check.UseVisualStyleBackColor = false;
			this.check.Click += new System.EventHandler(this.btnFinish_Click);
			// 
			// form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 540);
			this.Controls.Add(this.check);
			this.Controls.Add(this.shape);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "form1";
			this.Text = "Vẽ hình";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IsMouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IsMouseUp);
			this.shape.ResumeLayout(false);
			this.shape.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shape;
        private System.Windows.Forms.RadioButton hcn;
        private System.Windows.Forms.RadioButton Elip;
        private System.Windows.Forms.Button check;
    }
}

