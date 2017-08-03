using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// I decided to not go with Tetris because I had trouble wrapping my mind around creating it.
// I still wanted to stick to an Object Oriented classic video game and the same project plan, so I went with Pong instead.

namespace PongOOP
{
	public partial class Form1 : Form
	{
		Player player1, player2;
		public List<Ball> ballList;

		//Initalize everything for the program.
		public Form1()
		{
			InitializeComponent();

			player1 = new Player(Paddle1, LabelPlayer2);
			player2 = new Player(Paddle2, LabelPlayer1);
			ballList = new List<Ball>();
			StartNewGame();
		}


		//The process at the start of the game
		private void StartNewGame()
		{
			ballList.Add(new Ball(PongBall, player1, player2));
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			player1.Move();
			player2.Move();

			for (int i = ballList.Count - 1; i >= 0; i--)
			{
				if (ballList[i].Move())
				{
					ballList.RemoveAt(i);
				}
			}

			if (ballList.Count == 0)
			{
				StartNewGame();
			}
		}

	//Game controls section
	private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeys(e, true);
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			CheckKeys(e, false);
		}

		//Player 1 uses W and S to move
		//Player 2 uses the Up and Down arrow keys to move.
		private void CheckKeys(KeyEventArgs e, bool isDown)
		{
			switch (e.KeyCode)
			{
				case Keys.W:
					player1.isUpPressed = isDown;
					break;
				case Keys.S:
					player1.isDownPressed = isDown;
					break;

				case Keys.Up:
					player2.isUpPressed = isDown;
					break;
				case Keys.Down:
					player2.isDownPressed = isDown;
					break;
			}
		}
	}
}
