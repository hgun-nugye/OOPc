namespace FlappyBird
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.fllapyBird = new System.Windows.Forms.PictureBox();
			this.pipeTop = new System.Windows.Forms.PictureBox();
			this.ground = new System.Windows.Forms.PictureBox();
			this.pipeBottom = new System.Windows.Forms.PictureBox();
			this.scoreText = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.fllapyBird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
			this.SuspendLayout();
			// 
			// fllapyBird
			// 
			this.fllapyBird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fllapyBird.BackgroundImage")));
			this.fllapyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.fllapyBird.Location = new System.Drawing.Point(93, 167);
			this.fllapyBird.Name = "fllapyBird";
			this.fllapyBird.Size = new System.Drawing.Size(99, 76);
			this.fllapyBird.TabIndex = 0;
			this.fllapyBird.TabStop = false;
			// 
			// pipeTop
			// 
			this.pipeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeTop.BackgroundImage")));
			this.pipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
			this.pipeTop.Location = new System.Drawing.Point(828, 1);
			this.pipeTop.Name = "pipeTop";
			this.pipeTop.Size = new System.Drawing.Size(124, 197);
			this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeTop.TabIndex = 2;
			this.pipeTop.TabStop = false;
			// 
			// ground
			// 
			this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
			this.ground.Location = new System.Drawing.Point(-1, 553);
			this.ground.Name = "ground";
			this.ground.Size = new System.Drawing.Size(966, 120);
			this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ground.TabIndex = 3;
			this.ground.TabStop = false;
			// 
			// pipeBottom
			// 
			this.pipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom.Image")));
			this.pipeBottom.Location = new System.Drawing.Point(520, 337);
			this.pipeBottom.Name = "pipeBottom";
			this.pipeBottom.Size = new System.Drawing.Size(133, 214);
			this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeBottom.TabIndex = 4;
			this.pipeBottom.TabStop = false;
			// 
			// scoreText
			// 
			this.scoreText.AutoSize = true;
			this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreText.Location = new System.Drawing.Point(24, 15);
			this.scoreText.Name = "scoreText";
			this.scoreText.Size = new System.Drawing.Size(86, 20);
			this.scoreText.TabIndex = 5;
			this.scoreText.Text = "Score: 0 ";
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(964, 670);
			this.Controls.Add(this.fllapyBird);
			this.Controls.Add(this.scoreText);
			this.Controls.Add(this.pipeBottom);
			this.Controls.Add(this.pipeTop);
			this.Controls.Add(this.ground);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Flappy Bird Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.fllapyBird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox fllapyBird;
		private System.Windows.Forms.PictureBox pipeTop;
		private System.Windows.Forms.PictureBox ground;
		private System.Windows.Forms.PictureBox pipeBottom;
		private System.Windows.Forms.Label scoreText;
		private System.Windows.Forms.Timer gameTimer;
	}
}

