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
            this.shape.Location = new System.Drawing.Point(606, 22);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(182, 121);
            this.shape.TabIndex = 0;
            this.shape.TabStop = false;
            this.shape.Text = "Vẽ hình";
            // 
            // hcn
            // 
            this.hcn.AutoSize = true;
            this.hcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hcn.Location = new System.Drawing.Point(24, 69);
            this.hcn.Name = "hcn";
            this.hcn.Size = new System.Drawing.Size(157, 29);
            this.hcn.TabIndex = 1;
            this.hcn.TabStop = true;
            this.hcn.Text = "Hình chữ nhật";
            this.hcn.UseVisualStyleBackColor = true;
            // 
            // Elip
            // 
            this.Elip.AutoSize = true;
            this.Elip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elip.Location = new System.Drawing.Point(24, 34);
            this.Elip.Name = "Elip";
            this.Elip.Size = new System.Drawing.Size(69, 29);
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
            this.check.Location = new System.Drawing.Point(606, 167);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(138, 49);
            this.check.TabIndex = 1;
            this.check.Text = "CHECK";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.check);
            this.Controls.Add(this.shape);
            this.Name = "form1";
            this.Text = "Vẽ hình";
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

