using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongOOP
{
	public class Player
	{
		const int movementSpeed = 3;

		public bool isUpPressed, isDownPressed;

		public PictureBox paddle;

		Label gameScore;
		bool? wasGoingUpLastTick;
		int numberofTicksGoingInTheSameDirection;

		int score_;

		public int score
		{
			get
			{
				return score_;
			}
			set
			{
				score_ = value;
				gameScore.Text = score.ToString();
			}
		}
		public Player(PictureBox paddle1, Label gameScore)
		{
			this.paddle = paddle1;
			this.gameScore = gameScore;
		}

		internal void Move()
		{
			bool? goingUp = null;

			if (isUpPressed)
			{
				goingUp = true;
			}

			if (isDownPressed)
			{
				if (goingUp.HasValue)
				{
					goingUp = null;
				}
				else
				{
					goingUp = false;
				}
			}

			if (wasGoingUpLastTick.HasValue)
			{
				if (!goingUp.HasValue)
				{
					wasGoingUpLastTick = null;
					numberofTicksGoingInTheSameDirection = 0;
				}
				else if (wasGoingUpLastTick.Value == goingUp.Value)
				{
					numberofTicksGoingInTheSameDirection++;
				}
				else
				{
					wasGoingUpLastTick = goingUp;
					numberofTicksGoingInTheSameDirection = 1;
				}
			}
			else if (goingUp.HasValue)
			{
				wasGoingUpLastTick = goingUp;
				numberofTicksGoingInTheSameDirection = 1;
			}

			DoMove(goingUp);
		}

		private void DoMove(bool? goingUp)
		{
			if (goingUp.HasValue)
			{
				var speed = (int)Math.Round(movementSpeed * ((float)numberofTicksGoingInTheSameDirection / 10));
				if (goingUp.Value)
				{
					speed *= -1;
				}

				paddle.Location = new System.Drawing.Point(paddle.Location.X, Math.Max(PongMap.topOfMap, Math.Min(PongMap.bottomOfMap - paddle.Height, paddle.Location.Y + speed)
						)
					);
			}
		}
	}
}

