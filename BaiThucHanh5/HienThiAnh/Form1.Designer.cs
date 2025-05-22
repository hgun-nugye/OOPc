namespace HienThiAnh
{
    partial class imageShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imageShow));
            this.open = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.AutoSize = true;
            this.open.BackColor = System.Drawing.SystemColors.ControlLight;
            this.open.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(524, 62);
            this.open.Name = "open";
            this.open.Padding = new System.Windows.Forms.Padding(10);
            this.open.Size = new System.Drawing.Size(108, 51);
            this.open.TabIndex = 0;
            this.open.Text = "OPEN";
            this.open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(524, 163);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(10);
            this.close.Size = new System.Drawing.Size(121, 51);
            this.close.TabIndex = 1;
            this.close.Text = "CLOSE";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // picture
            // 
            this.picture.BackgroundImage = global::HienThiAnh.Properties.Resources.capy5;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picture.ErrorImage")));
            this.picture.Location = new System.Drawing.Point(65, 50);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(391, 248);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // imageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 362);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.close);
            this.Controls.Add(this.open);
            this.Name = "imageShow";
            this.Text = "Hiển thị ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label open;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox picture;
    }
}

