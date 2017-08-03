using System;
using System.Windows.Forms;
using System.Drawing;

namespace PongOOP
{
	public class Ball
	{
		private PictureBox ball;
		Random rand = new Random();
		Player leftsidePlayer, rightsidePlayer;
		int xSpeed, ySpeed;

		public Ball(PictureBox PongBall, Player leftsidePlayer, Player rightsidePlayer)
		{
			this.ball = PongBall;
			this.leftsidePlayer = leftsidePlayer;
			this.rightsidePlayer = rightsidePlayer;
			xSpeed = 1;
			ySpeed = 2;
			ResetBall();
		}

		//Movement, including the ball speed
		internal bool Move()
		{
			DoMove();

			var bottom = PongMap.bottomOfMap - ball.Height;

			if (ball.Location.Y >= bottom || ball.Location.Y <= PongMap.topOfMap)
			{
				ySpeed *= -1;
			}

			if (ball.Location.X <= PongMap.leftOfMap)
			{
				Score(leftsidePlayer);
				return true;
			}
			else if (ball.Location.X >= PongMap.rightOfMap - ball.Width)
			{
				Score(rightsidePlayer);
				return true;
			}


			if (leftsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)
				|| rightsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
			{
				
				xSpeed *= -2;
				ySpeed *= 1;

				while (leftsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds) 
					|| rightsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
				{
					DoMove();
				}
			}

			return false;
		}

		private int DoMove()
		{
			var bottom = PongMap.bottomOfMap - ball.Height;
			ball.Location = new Point(ball.Location.X + xSpeed,
				Math.Max(PongMap.topOfMap, Math.Min(bottom, ball.Location.Y + ySpeed))
				);
			return bottom;
		}

		//When a player scores, increase their score count.
		private void Score(Player winningPlayer)
		{
			winningPlayer.score++;
		}

		//Resets after a player scores
		private void ResetBall()
		{
			ball.Location = new Point((PongMap.leftOfMap + PongMap.rightOfMap) / 2,
							(PongMap.topOfMap + PongMap.bottomOfMap) / 2);
			do
			{
				xSpeed = rand.Next(-3, 3);
				ySpeed = rand.Next(-3, 3);
			} while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3 || Math.Abs(xSpeed) <= 1);
		}
	}
}
