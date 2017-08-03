namespace PongOOP
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
			this.Paddle1 = new System.Windows.Forms.PictureBox();
			this.Paddle2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.LabelPlayer1 = new System.Windows.Forms.Label();
			this.LabelPlayer2 = new System.Windows.Forms.Label();
			this.ScoreDivider = new System.Windows.Forms.Label();
			this.LabelScore = new System.Windows.Forms.Label();
			this.PongBall = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PongBall)).BeginInit();
			this.SuspendLayout();
			// 
			// Paddle1
			// 
			this.Paddle1.Image = ((System.Drawing.Image)(resources.GetObject("Paddle1.Image")));
			this.Paddle1.Location = new System.Drawing.Point(12, 225);
			this.Paddle1.Name = "Paddle1";
			this.Paddle1.Size = new System.Drawing.Size(22, 202);
			this.Paddle1.TabIndex = 0;
			this.Paddle1.TabStop = false;
			// 
			// Paddle2
			// 
			this.Paddle2.Image = ((System.Drawing.Image)(resources.GetObject("Paddle2.Image")));
			this.Paddle2.Location = new System.Drawing.Point(1274, 225);
			this.Paddle2.Name = "Paddle2";
			this.Paddle2.Size = new System.Drawing.Size(22, 202);
			this.Paddle2.TabIndex = 1;
			this.Paddle2.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PongOOP.Properties.Settings.Default, "Score", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.label1.Location = new System.Drawing.Point(481, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = global::PongOOP.Properties.Settings.Default.Score;
			// 
			// LabelPlayer1
			// 
			this.LabelPlayer1.AutoSize = true;
			this.LabelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LabelPlayer1.Location = new System.Drawing.Point(612, 46);
			this.LabelPlayer1.Name = "LabelPlayer1";
			this.LabelPlayer1.Size = new System.Drawing.Size(35, 37);
			this.LabelPlayer1.TabIndex = 7;
			this.LabelPlayer1.Text = "0";
			// 
			// LabelPlayer2
			// 
			this.LabelPlayer2.AutoSize = true;
			this.LabelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LabelPlayer2.Location = new System.Drawing.Point(712, 46);
			this.LabelPlayer2.Name = "LabelPlayer2";
			this.LabelPlayer2.Size = new System.Drawing.Size(35, 37);
			this.LabelPlayer2.TabIndex = 8;
			this.LabelPlayer2.Text = "0";
			// 
			// ScoreDivider
			// 
			this.ScoreDivider.AutoSize = true;
			this.ScoreDivider.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScoreDivider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ScoreDivider.Location = new System.Drawing.Point(666, 46);
			this.ScoreDivider.Name = "ScoreDivider";
			this.ScoreDivider.Size = new System.Drawing.Size(31, 37);
			this.ScoreDivider.TabIndex = 9;
			this.ScoreDivider.Text = "||";
			// 
			// LabelScore
			// 
			this.LabelScore.AutoSize = true;
			this.LabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LabelScore.Location = new System.Drawing.Point(630, 9);
			this.LabelScore.Name = "LabelScore";
			this.LabelScore.Size = new System.Drawing.Size(100, 37);
			this.LabelScore.TabIndex = 10;
			this.LabelScore.Text = "Score";
			// 
			// PongBall
			// 
			this.PongBall.Image = ((System.Drawing.Image)(resources.GetObject("PongBall.Image")));
			this.PongBall.Location = new System.Drawing.Point(675, 247);
			this.PongBall.Name = "PongBall";
			this.PongBall.Size = new System.Drawing.Size(20, 20);
			this.PongBall.TabIndex = 11;
			this.PongBall.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.textBox1.CausesValidation = false;
			this.textBox1.Enabled = false;
			this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
			this.textBox1.Location = new System.Drawing.Point(561, 617);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(252, 20);
			this.textBox1.TabIndex = 12;
			this.textBox1.Text = "Player 1: W, S to move. | Player 2: Up, Down Arrows";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1308, 649);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Paddle2);
			this.Controls.Add(this.Paddle1);
			this.Controls.Add(this.PongBall);
			this.Controls.Add(this.LabelScore);
			this.Controls.Add(this.ScoreDivider);
			this.Controls.Add(this.LabelPlayer2);
			this.Controls.Add(this.LabelPlayer1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pong";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.Paddle1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PongBall)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Paddle1;
		private System.Windows.Forms.PictureBox Paddle2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LabelPlayer1;
		private System.Windows.Forms.Label LabelPlayer2;
		private System.Windows.Forms.Label ScoreDivider;
		private System.Windows.Forms.Label LabelScore;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.PictureBox PongBall;
	}
}

