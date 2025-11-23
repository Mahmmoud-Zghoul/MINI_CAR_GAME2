namespace Mini_Car_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            car = new PictureBox();
            enemy1 = new PictureBox();
            enemy3 = new PictureBox();
            enemy2 = new PictureBox();
            over = new Label();
            score = new Label();
            coin1 = new PictureBox();
            coin4 = new PictureBox();
            coin2 = new PictureBox();
            coin3 = new PictureBox();
            Restart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(234, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(234, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 103);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(234, 315);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 86);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(234, 451);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 199);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(3, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(10, 670);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Location = new Point(471, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(10, 649);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // car
            // 
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(73, 351);
            car.Name = "car";
            car.Size = new Size(40, 82);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 9;
            car.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(34, 192);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(38, 50);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 10;
            enemy1.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(390, 214);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(36, 50);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 13;
            enemy3.TabStop = false;
            enemy3.Click += pictureBox10_Click;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(262, 85);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(36, 50);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 14;
            enemy2.TabStop = false;
            enemy2.Click += pictureBox11_Click;
            // 
            // over
            // 
            over.AutoSize = true;
            over.BackColor = Color.Black;
            over.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            over.ForeColor = Color.Red;
            over.Location = new Point(92, 214);
            over.Name = "over";
            over.Size = new Size(278, 65);
            over.TabIndex = 15;
            over.Text = "Game Over";
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.ForeColor = Color.Yellow;
            score.Location = new Point(12, 1);
            score.Name = "score";
            score.Size = new Size(94, 30);
            score.TabIndex = 16;
            score.Text = "Coins=0";
            // 
            // coin1
            // 
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(122, 76);
            coin1.Name = "coin1";
            coin1.Size = new Size(30, 30);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 17;
            coin1.TabStop = false;
            // 
            // coin4
            // 
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(292, 351);
            coin4.Name = "coin4";
            coin4.Size = new Size(50, 50);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 18;
            coin4.TabStop = false;
            // 
            // coin2
            // 
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(365, 127);
            coin2.Name = "coin2";
            coin2.Size = new Size(30, 30);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 19;
            coin2.TabStop = false;
            // 
            // coin3
            // 
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(92, 287);
            coin3.Name = "coin3";
            coin3.Size = new Size(50, 50);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 20;
            coin3.TabStop = false;
            // 
            // Restart
            // 
            Restart.BackColor = Color.White;
            Restart.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Restart.ForeColor = SystemColors.ActiveCaptionText;
            Restart.Location = new Point(137, 468);
            Restart.Name = "Restart";
            Restart.Size = new Size(205, 59);
            Restart.TabIndex = 21;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = false;
            Restart.Click += Restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(484, 561);
            Controls.Add(Restart);
            Controls.Add(coin3);
            Controls.Add(coin2);
            Controls.Add(coin4);
            Controls.Add(coin1);
            Controls.Add(score);
            Controls.Add(over);
            Controls.Add(enemy2);
            Controls.Add(enemy3);
            Controls.Add(enemy1);
            Controls.Add(car);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private PictureBox car;
        private PictureBox enemy1;
        private PictureBox enemy3;
        private PictureBox enemy2;
        private Label over;
        private Label score;
        private PictureBox coin1;
        private PictureBox coin4;
        private PictureBox coin2;
        private PictureBox coin3;
        private Button Restart;
    }
}
