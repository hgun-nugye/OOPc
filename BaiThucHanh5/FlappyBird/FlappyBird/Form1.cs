using System;
using System.Windows.Forms;

namespace FlappyBird
{
	public partial class Form1 : Form
	{
		int pipeSpeed = 5; // Speed of the pipes
		int gravity = 10; // Gravity effect on the bird
		int score = 0; // Player's score
		public Form1()
		{
			InitializeComponent();
		}

		private void gameTimer_Tick(object sender, EventArgs e)
		{
			fllapyBird.Top += gravity; // Apply gravity to the bird
			pipeBottom.Left -= pipeSpeed; // Move the bottom pipe left
			pipeTop.Left -= pipeSpeed; // Move the top pipe left
			scoreText.Text = "Score: " + score.ToString(); // Display initial score


			if (pipeBottom.Left < -150) // If the pipe is off screen
			{
				pipeBottom.Left = 800; // Reset pipe position
				score++; // Increase score
			}
			if (pipeTop.Left < -180) // If the top pipe is off screen
			{
				pipeTop.Left = 800; // Reset top pipe position
				score++; // Increase score
			}

			if (fllapyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
				fllapyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
				fllapyBird.Bounds.IntersectsWith(ground.Bounds))
			{
				EndGame(); // End the game if bird collides with pipes or ground
			}

			if (score>5)
			{
				pipeSpeed = 10; // Increase pipe speed after score reaches 5
			}
			else if (score > 10)
			{
				pipeSpeed = 15; // Increase pipe speed after score reaches 10
			}
			else if (score > 15)
			{
				pipeSpeed = 20; // Increase pipe speed after score reaches 15
			}

			if(fllapyBird.Top < 0 || fllapyBird.Top > this.ClientSize.Height - fllapyBird.Height)
			{
				EndGame(); // End the game if bird goes out of bounds
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = -10;

			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = 10;
			}
		}
		private void EndGame()
		{
			gameTimer.Stop(); // Stop the game timer
			MessageBox.Show("Game Over! Your score: " + score); // Show game over message
			Application.Exit(); // Exit the application
		}
	}

}
