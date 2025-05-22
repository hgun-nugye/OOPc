namespace PTBac2
{
    partial class PTB2
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
            this.a = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.inputa = new System.Windows.Forms.TextBox();
            this.inputc = new System.Windows.Forms.TextBox();
            this.inputb = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Button();
            this.esc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(29, 24);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(167, 29);
            this.a.TabIndex = 0;
            this.a.Text = "Nhập hệ số a";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(29, 127);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(166, 29);
            this.c.TabIndex = 1;
            this.c.Text = "Nhập hệ số c";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(28, 73);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(168, 29);
            this.b.TabIndex = 2;
            this.b.Text = "Nhập hệ số b";
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // inputa
            // 
            this.inputa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputa.Location = new System.Drawing.Point(217, 24);
            this.inputa.Name = "inputa";
            this.inputa.Size = new System.Drawing.Size(214, 30);
            this.inputa.TabIndex = 3;
            // 
            // inputc
            // 
            this.inputc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputc.Location = new System.Drawing.Point(217, 126);
            this.inputc.Name = "inputc";
            this.inputc.Size = new System.Drawing.Size(214, 30);
            this.inputc.TabIndex = 4;
            // 
            // inputb
            // 
            this.inputb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputb.Location = new System.Drawing.Point(217, 72);
            this.inputb.Name = "inputb";
            this.inputb.Size = new System.Drawing.Size(214, 30);
            this.inputb.TabIndex = 5;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(54, 191);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(148, 50);
            this.result.TabIndex = 6;
            this.result.Text = "Giải";
            this.result.UseVisualStyleBackColor = false;
            this.result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.result_MouseClick);
            // 
            // esc
            // 
            this.esc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.esc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esc.Location = new System.Drawing.Point(250, 191);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(148, 50);
            this.esc.TabIndex = 7;
            this.esc.Text = "Thoát";
            this.esc.UseVisualStyleBackColor = false;
            this.esc.Click += new System.EventHandler(this.esc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nghiệm của phương trình:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(490, 72);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(337, 169);
            this.output.TabIndex = 9;
            // 
            // PTB2
            // 
            this.ClientSize = new System.Drawing.Size(866, 298);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputb);
            this.Controls.Add(this.inputc);
            this.Controls.Add(this.inputa);
            this.Controls.Add(this.b);
            this.Controls.Add(this.c);
            this.Controls.Add(this.a);
            this.Name = "PTB2";
            this.Text = "Giải Phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox inputa;
        private System.Windows.Forms.TextBox inputc;
        private System.Windows.Forms.TextBox inputb;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button esc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
    }
}

