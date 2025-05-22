
namespace DrawShapes
{
    partial class frmDrawShapes
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
            this.groupShapes = new System.Windows.Forms.GroupBox();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupShapes
            // 
            this.groupShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupShapes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupShapes.Controls.Add(this.radioRectangle);
            this.groupShapes.Controls.Add(this.radioCircle);
            this.groupShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupShapes.Location = new System.Drawing.Point(625, 14);
            this.groupShapes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupShapes.Name = "groupShapes";
            this.groupShapes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupShapes.Size = new System.Drawing.Size(178, 126);
            this.groupShapes.TabIndex = 0;
            this.groupShapes.TabStop = false;
            this.groupShapes.Text = "Shape";
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRectangle.Location = new System.Drawing.Point(20, 75);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(147, 33);
            this.radioRectangle.TabIndex = 1;
            this.radioRectangle.Text = "Rectangle";
            this.radioRectangle.UseVisualStyleBackColor = true;
            // 
            // radioCircle
            // 
            this.radioCircle.AutoSize = true;
            this.radioCircle.Checked = true;
            this.radioCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCircle.Location = new System.Drawing.Point(20, 36);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(106, 33);
            this.radioCircle.TabIndex = 0;
            this.radioCircle.TabStop = true;
            this.radioCircle.Text = "Elipse";
            this.radioCircle.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinish.Location = new System.Drawing.Point(625, 160);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(178, 41);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Check";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // frmDrawShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(816, 599);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupShapes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDrawShapes";
            this.Text = "Draw Shapes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IsMouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IsMouseUp);
            this.groupShapes.ResumeLayout(false);
            this.groupShapes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupShapes;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.RadioButton radioCircle;
        private System.Windows.Forms.Button btnFinish;
    }
}

