using System;
using System.Windows.Forms;
using System.Drawing;

namespace PongOOP
{
	public class Ball
	{
		Form1 form;
		private PictureBox ballPictureBox, ballModel;
		Random rand = new Random();
		Player leftsidePlayer, rightsidePlayer;
		int xSpeed, ySpeed;

		public Ball(Form1 form, PictureBox PongBall, Player leftsidePlayer, Player rightsidePlayer)
		{
			this.form = form;
			ballModel = PongBall;
			this.ballPictureBox = new PictureBox();
			this.ballPictureBox.Image = PongBall.Image;
			this.ballPictureBox.Size = PongBall.Size;
			form.Controls.Add(ballPictureBox);
			this.leftsidePlayer = leftsidePlayer;
			this.rightsidePlayer = rightsidePlayer;
			ResetBall();
		}

		internal bool Move()
		{
			DoMove();

			var bottom = PongMap.bottomOfMap - ballPictureBox.Height;
			if (ballPictureBox.Location.Y >= bottom || ballPictureBox.Location.Y <= PongMap.topOfMap)
			{
				ySpeed *= -1;
			}

			if (ballPictureBox.Location.X <= PongMap.leftOfMap)
			{
				Score(leftsidePlayer);
				return true;
			}
			else if (ballPictureBox.Location.X >= PongMap.rightOfMap - ballPictureBox.Width)
			{
				Score(rightsidePlayer);
				return true;
			}

			if (leftsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds)
				|| rightsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds))
			{
				xSpeed *= -1;

				form.ballList.Add(new Ball(form, ballModel, leftsidePlayer, rightsidePlayer));

				while (leftsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds) 
					|| rightsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds))
				{
					DoMove();
				}
			}

			return false;
		}

		private int DoMove()
		{
			var bottom = PongMap.bottomOfMap - ballPictureBox.Height;
			ballPictureBox.Location = new Point(ballPictureBox.Location.X + xSpeed,
				Math.Max(PongMap.topOfMap, Math.Min(bottom, ballPictureBox.Location.Y + ySpeed))
				);
			return bottom;
		}

		private void Score(Player winningPlayer)
		{
			winningPlayer.score++;
			form.Controls.Remove(ballPictureBox);
		}

		private void ResetBall()
		{
			ballPictureBox.Location = new Point((PongMap.leftOfMap + PongMap.rightOfMap) / 2,
							(PongMap.topOfMap + PongMap.bottomOfMap) / 2);
			do
			{
				xSpeed = rand.Next(-3, 3);
				ySpeed = rand.Next(-3, 3);
			} while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3 || Math.Abs(xSpeed) <= 1);
		}
	}
}
