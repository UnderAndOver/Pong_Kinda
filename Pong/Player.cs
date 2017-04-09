using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    class Player
    {
        private const int Movementspeed = 3;
        public bool isUpPressed, isDownPressed;
        private bool? wasup;
        private int numTicksSameDir;
        public PictureBox paddle;
        private Label scoreLabel;

        int _score;

        public int score
        {
            get { return _score; }
            set
            {
                _score = value;
                scoreLabel.Text = score.ToString();
                if(int.Parse(score.ToString())==7)
                    Form1.Winner();
            }
        }
        public Player(PictureBox paddle,Label scoreLabel)
        {
            this.paddle = paddle;
            this.scoreLabel = scoreLabel;
        }

        internal void ProcessMove()
        {
            bool? up = null;
            if (isUpPressed)
                up = true;
            if (isDownPressed)
            {
                if (up.HasValue)
                    up = null;
                else
                {
                    up = false;
                }
            }
            if (wasup.HasValue)
            {
                if (!up.HasValue)
                {
                    wasup = null;
                    numTicksSameDir = 0;
                }
                else if (wasup.Value == up.Value)
                {
                    numTicksSameDir++;
                }
                else
                {
                    wasup = up;
                    numTicksSameDir = 1;
                }
            }
            else if (up.HasValue)
            {
                wasup = up;
                numTicksSameDir = 1;
            }
            DoMove(up);
        }

        private void DoMove(bool? up)
        {
            if (up.HasValue)
            {
                var speed = (int)Math.Round(Movementspeed * ((float)numTicksSameDir / 9));
                if (up.Value)
                    speed *= -1;
                var bottom = World.LowerBoundary - paddle.Height;
                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(World.TopBoundary,
                        Math.Min(bottom, paddle.Location.Y + speed)));
            }
        }
    }
}
