using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    class Ball
    {
        private PictureBox ball;
        private Random rand=new Random();
        private int xSpeed, ySpeed;
        private Player leftPlayer, rightPlayer;
        public Ball(PictureBox pongBall,Player leftPlayer,Player rightPlayer)
        {
            this.ball = pongBall;
            this.leftPlayer = leftPlayer;
            this.rightPlayer = rightPlayer;
            ResetBall();
        }

        public void ProcessMove()
        {
            DoMove();
            var bottom = World.LowerBoundary - ball.Height;
            if (ball.Location.Y >= bottom || ball.Location.Y <= World.TopBoundary)
                ySpeed *= -1;

            if (ball.Location.X <= World.leftBoundary)
            {
                Score(leftPlayer);
            }
            else if (ball.Location.X >= World.rightBoundary)
            {
                Score(rightPlayer);
            }

            if (leftPlayer.paddle.Bounds.IntersectsWith(ball.Bounds) ||
                rightPlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
            {
                xSpeed *= -1;
                ySpeed *= 1;
            }
            while (leftPlayer.paddle.Bounds.IntersectsWith(ball.Bounds) ||
                   rightPlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
            {
                DoMove();
            }

        }

        private int DoMove()
        {
            var bottom = World.LowerBoundary - ball.Height;
            ball.Location = new Point(ball.Location.X + xSpeed,
                Math.Max(World.TopBoundary,
                Math.Min(bottom, ball.Location.Y + ySpeed)));
            return bottom;
        }

        private void Score(Player winner)
        {
            winner.score++;
            ResetBall();
        }

        private void ResetBall()
        {
            ball.Location = new Point((World.leftBoundary + World.rightBoundary) / 2,
                ((World.TopBoundary + World.LowerBoundary) / 2));
            const int speedconst=7;
            do
            {
                xSpeed = rand.Next(-speedconst, speedconst);
                ySpeed = rand.Next(-speedconst, speedconst);
            } while (Math.Abs(xSpeed)+Math.Abs(ySpeed)<=10 || Math.Abs(xSpeed)<=1);
        }
    }
}
