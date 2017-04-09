using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        Player player1, player2;
        private Ball ball;
        public Form1()
        {
            InitializeComponent();
            player1 = new Player(Paddle1, labelplayer1);
            player2 = new Player(Paddle2, labelplayer2);
            ball = new Ball(PongBall,player1,player2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player1.ProcessMove();
            player2.ProcessMove();
            ball.ProcessMove();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKey(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKey(e, false);
        }

        private void CheckKey(KeyEventArgs e, bool isDown)
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

        public static void Winner()
        {

            Application.Restart();
        }
    }
}
