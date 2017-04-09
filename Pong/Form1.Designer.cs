namespace Pong
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
            this.PongBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelplayer2 = new System.Windows.Forms.Label();
            this.labelplayer1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PongBall)).BeginInit();
            this.SuspendLayout();
            // 
            // Paddle1
            // 
            this.Paddle1.Image = ((System.Drawing.Image)(resources.GetObject("Paddle1.Image")));
            this.Paddle1.Location = new System.Drawing.Point(12, 138);
            this.Paddle1.Name = "Paddle1";
            this.Paddle1.Size = new System.Drawing.Size(20, 143);
            this.Paddle1.TabIndex = 0;
            this.Paddle1.TabStop = false;
            // 
            // Paddle2
            // 
            this.Paddle2.Image = ((System.Drawing.Image)(resources.GetObject("Paddle2.Image")));
            this.Paddle2.Location = new System.Drawing.Point(1123, 138);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(20, 143);
            this.Paddle2.TabIndex = 1;
            this.Paddle2.TabStop = false;
            // 
            // PongBall
            // 
            this.PongBall.Image = ((System.Drawing.Image)(resources.GetObject("PongBall.Image")));
            this.PongBall.Location = new System.Drawing.Point(536, 192);
            this.PongBall.Name = "PongBall";
            this.PongBall.Size = new System.Drawing.Size(36, 34);
            this.PongBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PongBall.TabIndex = 2;
            this.PongBall.TabStop = false;
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
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // labelplayer2
            // 
            this.labelplayer2.AutoSize = true;
            this.labelplayer2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelplayer2.Location = new System.Drawing.Point(490, 53);
            this.labelplayer2.Name = "labelplayer2";
            this.labelplayer2.Size = new System.Drawing.Size(41, 44);
            this.labelplayer2.TabIndex = 4;
            this.labelplayer2.Text = "0";
            // 
            // labelplayer1
            // 
            this.labelplayer1.AutoSize = true;
            this.labelplayer1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelplayer1.Location = new System.Drawing.Point(583, 53);
            this.labelplayer1.Name = "labelplayer1";
            this.labelplayer1.Size = new System.Drawing.Size(41, 44);
            this.labelplayer1.TabIndex = 5;
            this.labelplayer1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(548, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1155, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelplayer1);
            this.Controls.Add(this.labelplayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PongBall);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.Paddle1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
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
        private System.Windows.Forms.PictureBox PongBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelplayer1;
        private System.Windows.Forms.Label labelplayer2;
        private System.Windows.Forms.Label label4;
    }
}

